using System;
using System.ComponentModel.DataAnnotations;
using SuxrobGM.Sdk.Utils;
using EC_Website.Core.Interfaces.Entities;

namespace EC_Website.Core.Entities.Base
{
    public abstract class EntityBase : IEntity<string>
    {
        protected EntityBase()
        {
            Id = GeneratorId.GenerateLong();
            Timestamp = DateTime.Now;
        }

        [StringLength(32)]
        [Display(Name = "ID")]
        public string Id { get; set; }

        [Display(Name = "Timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
