//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vimas.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUserViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<Vimas.Models.Entities.AspNetUser>
    {
    	
    			public virtual string Id { get; set; }
    			public virtual string Email { get; set; }
    			public virtual bool EmailConfirmed { get; set; }
    			public virtual string PasswordHash { get; set; }
    			public virtual string SecurityStamp { get; set; }
    			public virtual string PhoneNumber { get; set; }
    			public virtual bool PhoneNumberConfirmed { get; set; }
    			public virtual bool TwoFactorEnabled { get; set; }
    			public virtual Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
    			public virtual bool LockoutEnabled { get; set; }
    			public virtual int AccessFailedCount { get; set; }
    			public virtual string UserName { get; set; }
    	
    	public AspNetUserViewModel() : base() { }
    	public AspNetUserViewModel(Vimas.Models.Entities.AspNetUser entity) : base(entity) { }
    
    }
}
