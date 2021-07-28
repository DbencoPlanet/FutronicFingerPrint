﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Futronic.Models
{

    [Serializable]
    public class FingerPrint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id{ get; set; }
        public byte[] Thumb { get; set; }
        public byte[] IndexFinger { get; set; }
        public byte[] MiddleFinger { get; set; }
        public byte[] RingFinger { get; set; }
        public byte[] LittleFinger { get; set; }

        [InverseProperty("LeftHand")]
        public virtual ICollection<User> LeftHand { get; set; }
        [InverseProperty("RightHand")]
        public virtual ICollection<User> RightHand { get; set; }
    }
}
