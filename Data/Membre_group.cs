//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Membre_group
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int MembreId { get; set; }
    
        public virtual Groupe_thematiqe Groupe_thematiqe { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}