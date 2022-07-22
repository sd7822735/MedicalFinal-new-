﻿using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.ViewComponents
{
    public class preview:ViewComponent
    {
        private readonly MedicalContext _medicalContext;
        public preview(MedicalContext medicalContext)
        {
            _medicalContext = medicalContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(CClinicDetailAdminViewModel cVM)
        {
            if (cVM == null)
                return View(null);

            DateTime dtForm = DateTime.Parse(cVM.dateForm);
            DateTime dtTo = DateTime.Parse(cVM.dateTo);
            int[] day = cVM.day;
            int[] time = cVM.time;
            TimeSpan Diff_dates = dtTo.Subtract(dtForm);
            int count = 0;

            List<CClinicDetailAdminViewModel> list = new List<CClinicDetailAdminViewModel>();

            for (int i = 0; i < Diff_dates.Days; i++)
            {
                DateTime dt = dtForm.AddDays(i);
                if (dt.DayOfWeek != DayOfWeek.Saturday || dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    foreach (var d in day)
                    {
                        if ((int)dt.DayOfWeek == d)
                        {
                            foreach (var t in time)
                            {
                                CClinicDetailAdminViewModel cc = new CClinicDetailAdminViewModel();
                                //cc.DoctorId = cVM.DoctorId;
                                cc.doctorName = _medicalContext.Doctors.Where(x => x.DoctorId.Equals(cVM.DoctorId)).SingleOrDefault().DoctorName;
                                //cc.DepartmentId = (int)cVM.DepartmentId;
                                cc.deptName = _medicalContext.Departments.Where(x => x.DepartmentId.Equals(cVM.DepartmentId)).SingleOrDefault().DeptName;
                                cc.ClinicDate = dt;
                                cc.periodName = _medicalContext.Periods.Where(x => x.PeriodId.Equals(t)).SingleOrDefault().PeriodDetail;
                                cc.RoomId = cVM.room;
                                cc.Online = 0;

                                var qry = _medicalContext.ClinicDetails.Where(x => x.ClinicDate.Value.Date.Equals(dt.Date) && x.PeriodId.Equals(t));
                                if (qry.Count() > 0)
                                {
                                    cc.repeat = true;
                                    count++;
                                }
                                else
                                {
                                    cc.repeat = false;

                                }

                                list.Add(cc);
                            }
                        }
                    }
                }
            }

            TempData["repeatKey"] = count.ToString();
            return View(list);
        }
    }
}
