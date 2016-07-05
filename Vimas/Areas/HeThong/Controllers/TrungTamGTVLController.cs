﻿using AutoMapper.QueryableExtensions;
using SkyWeb.DatVM.Mvc;
using SkyWeb.DatVM.Mvc.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Vimas.Models;
using Vimas.Models.Entities.Services;
using Vimas.ViewModels;

namespace Vimas.Areas.HeThong.Controllers
{
    [Authorize]
    public class TrungTamGTVLController : BaseController
    {
        // GET: HeThong/TrungTamGTVL
        #region Index
        public ActionResult Index()
        {
            return this.View();
        }
        public JsonResult LoadDanhSachTrungTam(JQueryDataTableParamModel param)
        {
            var service = this.Service<ITrungTamGTVLService>();
            var model = service.GetActive().ProjectTo<TrungTamGTVLViewModel>(this.MapperConfig).ToList();
            try
            {
                var count = 0;
                var rs = model
                    .Where(q => string.IsNullOrEmpty(param.sSearch)
                        || q.TenCoSo.ToLower().Contains(param.sSearch.ToLower()))
                    .OrderBy(q => q.TenCoSo)
                    .Skip(param.iDisplayStart)
                    .Take(param.iDisplayLength)
                    .Select(q => new IConvertible[]
                    {
                        count++,
                        q.MaNguon,
                        q.TenCoSo,
                        q.DiaChi,
                        q.DienThoai,
                        q.Fax,
                        q.SoHDLK,
                        q.Id,
                    });
                var totalRecords = rs.Count();
                return Json(new
                {
                    sEcho = param.sEcho,
                    iTotalRecords = totalRecords,
                    iTotalDisplayRecords = totalRecords,
                    aaData = rs
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = "Error" });
            }
        }
        #endregion

        #region Create
        [Authorize(Roles = "Admin, PhongNguon")]
        public ActionResult Create()
        {
            var model = new TrungTamGTVLViewModel();
            return this.View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin, PhongNguon")]
        public async Task<ActionResult> Create(TrungTamGTVLViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var service = this.Service<ITrungTamGTVLService>();
            model.Active = true;
            try
            {
                await service.CreateAsync(model.ToEntity());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return this.RedirectToAction("Index");
        }
        #endregion

        #region Edit
        [Authorize(Roles = "Admin, PhongNguon")]
        public ActionResult Edit(int id)
        {
            var service = this.Service<ITrungTamGTVLService>();

            var entity = service.Get(id);

            if (entity == null)
            {
                return HttpNotFound();
            }

            var model = Mapper.Map<TrungTamGTVLViewModel>(entity);

            return this.View(model);
        }

        [Authorize(Roles = "Admin, PhongNguon")]
        [HttpPost]
        public async Task<JsonResult> Edit(TrungTamGTVLViewModel model)
        {
            var service = this.Service<ITrungTamGTVLService>();

            if (!this.ModelState.IsValid)
            {
                return Json(new { success = false, message = "Đã có lỗi xảy ra, vui lòng kiểm tra lại thông tin." });
            }

            try
            {
                await service.UpdateAsync(model.ToEntity());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Json(new { success = false, message = "Đã có lỗi xảy ra, vui lòng kiểm thử lại." });
            }

            return Json(new { success = true, message = "Chỉnh sửa thông tin thành công." });
        } 
        #endregion

        [Authorize(Roles = "Admin, PhongNguon")]
        public async Task<JsonResult> Delete(int id)
        {
            var trungTamGTVLService = this.Service<ITrungTamGTVLService>();

            var entity = trungTamGTVLService.Get(id);

            if (entity == null)
            {
                return Json(new { success = false, message = "Không tồn tại trung tâm này, xin vui lòng thử lại." });
            }
            else
            {
                try
                {
                    entity.Active = false;
                    await trungTamGTVLService.UpdateAsync(entity);
                }
                catch (Exception e)
                {
                    return Json(new { success = false, message = "Xóa trung tâm thất bại, xin vui lòng thử lại." });
                };
            }
            return Json(new { success = true, message = "Xóa trung tâm thành công." });
        }
    }
}