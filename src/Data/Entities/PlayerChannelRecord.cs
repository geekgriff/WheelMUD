﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="PlayerChannelRecord.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by EntityRecord.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using ServiceStack.DataAnnotations;

    /// <summary>Represents a single PlayerChannel row in the PlayerChannel table.</summary>
    [Alias("PlayerChannels")]
    public partial class PlayerChannelRecord
    {
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual long PlayerID { get; set; }
        public virtual long ChannelID { get; set; }
    }
}