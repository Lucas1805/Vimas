//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vimas.Models.Entities.Services
{
    using System;
    using System.Collections.Generic;
    
    
    public partial interface IThongTinVeNuocService : SkyWeb.DatVM.Data.IBaseService<ThongTinVeNuoc>
    {
    }
    
    public partial class ThongTinVeNuocService : SkyWeb.DatVM.Data.BaseService<ThongTinVeNuoc>, IThongTinVeNuocService
    {
        public ThongTinVeNuocService(SkyWeb.DatVM.Data.IUnitOfWork unitOfWork, Repositories.IThongTinVeNuocRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
