<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="WebDemo2.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Src/jQuery%20v.3.3.1.min.js"></script>
    <script src="EasyUI/jquery.easyui.min.js"></script>
    <link href="EasyUI/themes/icon.css" rel="stylesheet" />
    <link href="EasyUI/themes/gray/easyui.css" rel="stylesheet" />
    <script src="Src/xml2.js"></script>
    </head>
<body>
<%--方案A<table id="tb" border="1">
    <tr>
        <th>编号</th>
        <th>名称</th>
    </tr>
</table>  --%><div>
        <select id="cc" class="easyui-combobox" name="dept" style="width:200px;">   
    <option value="aa">条件一</option>   
    <option>条件二</option>   
      
</select> 
    <input type="text" name="Search" id="SearchText"/>
    <a id="btnSearch" class="easyui-linkbutton" data-options="iconCls:'icon-search'" onclick="Search()">查询</a>  
              </div>


    <table id="dg"></table>  


<script>
        $(function () {
            $.ajax({
                url: 'http://localhost:8695/WebService1.asmx/getall',
                type:'post',
                dataType: 'xml',
                contentType: "application/xml; charset=utf-8",
                data: {},
                success: function (data) {
                    var x2js = new X2JS();
                    var json = x2js.xml2json(data);
                    var jsonObj = json.string.__text;
                    var next = eval(jsonObj);

                    //console.log(next);
                    //console.info(jsonObj);
                    //方案A
                    //$('#tb tr:gt(0)').remove();//删除之前的数据
                    //var s = '';
                    //for (var i = 0; i < next.length; i++) s += '<tr><td>' + next[i].actModelID + '</td><td>' + next[i].actModelName + '</td></tr>';
                    //$('#tb').append(s);
                    //方案B
                    $('#dg').datagrid('loadData', next);
                },
                error: function (error) {

                }
            })
        })
        function Search() {
            $.ajax({
                url: 'http://localhost:8695/WebService1.asmx/getSearch',
                type: 'get',
                dataType: 'xml',
                contentType: "application/xml",
                data: {
                      "SearchID": $('#SearchText').val()
                 },
                success: function (data) {
                    var x2js = new X2JS();
                    var json = x2js.xml2json(data);
                    var jsonObj = json.string.__text;
                    var next = eval(jsonObj);

                    console.log(next);
                    console.info(jsonObj);
                    //方案A
                    //$('#tb tr:gt(0)').remove();//删除之前的数据
                    //var s = '';
                    //for (var i = 0; i < next.length; i++) s += '<tr><td>' + next[i].actModelID + '</td><td>' + next[i].actModelName + '</td></tr>';
                    //$('#tb').append(s);
                    //方案B
                    $('#dg').datagrid('loadData', next);
                },
                error: function (error) {
                    console.info(error);
                }

            });
        }
        $('#dg').datagrid({
            fitColumns:true,
            columns: [[
                { field: 'actModelID', title: '编号', width: 100 },
                { field: 'actModelName', title: '名称', width: 100 },
                
            ]]
 

        });




    </script>
</body>
</html>
