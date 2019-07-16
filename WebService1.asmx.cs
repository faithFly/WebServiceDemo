using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
namespace WebDemo2
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //查询所有
        [WebMethod]
        public string getall() {
            string sql = "select * from dbo.AccountModel";
            DataTable table = new DataTable();
            table = DBHelper.GetTable(sql);
            //return DataTableToJsonWithJavaScriptSerializer(table);
            return DataTableToJsonWithJavaScriptSerializer(table);
        }
        // 将DataTable序列化成json方法
        //模糊查询
        public string DataTableToJsonWithJavaScriptSerializer(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return jsSerializer.Serialize(parentRow);
        }
        [WebMethod]
        public string getSearch(string SearchID) {
            string sql = string.Format("select * from dbo.AccountModel where actModelName like '%{0}%'", SearchID);
            DataTable table = DBHelper.GetTable(sql);
            return DataTableToJsonWithJavaScriptSerializer(table);
        }
        
    }
}
