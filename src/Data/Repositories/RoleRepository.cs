﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="RoleRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by Repository.cst on 4/9/2013 4:29:50 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using ServiceStack.OrmLite;
    using WheelMUD.Data.Entities;

    /// <summary>Repository for the Roles table.</summary>
    public partial class RoleRepository : IRoleRepository
    {
        public void Add(RoleRecord role)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Save(role);
                transaction.Commit();
            }
        }

        public void Update(RoleRecord role)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Update(role);
                transaction.Commit();
            }
        }

        public void Remove(RoleRecord role)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Delete(role);
                transaction.Commit();
            }
        }

        public RoleRecord GetById(long roleId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<RoleRecord>("ID = {0}", roleId);
        }

        public RoleRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<RoleRecord>("Name = {0}", name);
            }
        }

        public ICollection<RoleRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<RoleRecord>();
            }
        }
    }
}