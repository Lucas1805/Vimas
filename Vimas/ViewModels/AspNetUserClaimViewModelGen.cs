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
    
    public partial class AspNetUserClaimViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<Vimas.Models.Entities.AspNetUserClaim>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string UserId { get; set; }
    			public virtual string ClaimType { get; set; }
    			public virtual string ClaimValue { get; set; }
    	
    	public AspNetUserClaimViewModel() : base() { }
    	public AspNetUserClaimViewModel(Vimas.Models.Entities.AspNetUserClaim entity) : base(entity) { }
    
    }
}
