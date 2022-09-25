using NF_P_015_DBSchemaTool.Models;
using NF_P_015_DBSchemaTool.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NF_P_015_DBSchemaTool.Controllers
{
    public class SchemaController : Controller
    {
        /// <summary>
        /// 連線資料庫
        /// </summary>
        /// <param name="connectString">連線字串</param>
        /// <returns></returns>
        public JsonResult Connect(string connectString)
        {
            Session["ConnectString"] = connectString;
            var result = new ModelResult() { IsOk = true };
            return Json(result);
        }

        /// <summary>
        /// 總覽
        /// </summary>
        /// <returns></returns>
        public ActionResult Overview()
        {
            if (string.IsNullOrWhiteSpace((string)Session["ConnectString"]))
            {
                return RedirectToAction("Index", "Home");
            }
            var vm = new OverviewVm();
            #region mock
            vm = new OverviewVm
            {
                TableInfos = new List<TableInfo>
                {
                    new TableInfo
                    {
                        Name = "Test",
                        Description = "測試資料表",
                        Count = 2254,
                        Columns = new List<TableInfo.Column>
                        {
                            new TableInfo.Column
                            {
                                Name = "ID",
                                Description = "編號",
                                ColumnType = "int",
                                IsPrimaryKey = true,
                                NotNull = true,
                                DefaultValue = null,
                                Note = "自動+1"
                            },
                            new TableInfo.Column
                            {
                                Name = "Name",
                                Description = "姓名",
                                ColumnType = "nvarchar(20)",
                                IsPrimaryKey = false,
                                NotNull = false,
                                DefaultValue = null,
                                Note = null
                            },
                            new TableInfo.Column
                            {
                                Name = "Sex",
                                Description = "性別",
                                ColumnType = "char(1)",
                                IsPrimaryKey = false,
                                NotNull = false,
                                DefaultValue = null,
                                Note = "M:男 F:女"
                            }
                        }
                    }
                }
            };
            vm.TableInfos.Add(vm.TableInfos.First());
            vm.TableInfos.Add(vm.TableInfos.First());
            #endregion
            return View(vm);
        }
    }
}