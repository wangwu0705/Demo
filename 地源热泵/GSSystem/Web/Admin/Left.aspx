<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="GSSystem.Web.Admin.Left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理页面</title>
    <style type="text/css">
        BODY {
            BACKGROUND: #799ae1;
            MARGIN: 0px;
            FONT: 9pt 宋体;
        }

        TABLE {
            BORDER-RIGHT: 0px;
            BORDER-TOP: 0px;
            BORDER-LEFT: 0px;
            BORDER-BOTTOM: 0px;
        }

        TD {
            FONT: 12px 宋体;
        }

        IMG {
            BORDER-RIGHT: 0px;
            BORDER-TOP: 0px;
            VERTICAL-ALIGN: bottom;
            BORDER-LEFT: 0px;
            BORDER-BOTTOM: 0px;
        }

        A {
            FONT: 12px 宋体;
            COLOR: #000000;
            TEXT-DECORATION: none;
        }

            A:hover {
                COLOR: #428eff;
                TEXT-DECORATION: underline;
            }

        .sec_menu {
            BORDER-RIGHT: white 1px solid;
            BACKGROUND: #d6dff7;
            OVERFLOW: hidden;
            BORDER-LEFT: white 1px solid;
            BORDER-BOTTOM: white 1px solid;
        }

        .menu_title {
        }

            .menu_title SPAN {
                FONT-WEIGHT: bold;
                LEFT: 7px;
                COLOR: #215dc6;
                POSITION: relative;
                TOP: 2px;
            }

        .menu_title2 {
        }

            .menu_title2 SPAN {
                FONT-WEIGHT: bold;
                LEFT: 8px;
                COLOR: #428eff;
                POSITION: relative;
                TOP: 2px;
            }
        .auto-style1 {
            width: 31px;
        }
        .auto-style2 {
            width: 37px;
        }
        .auto-style3 {
            height: 20px;
        }
    </style>
    <script>
        function showsubmenu(sid) {
            whichEl = eval("submenu" + sid);
            if (whichEl.style.display == "none") {
                eval("submenu" + sid + ".style.display=\"\";");
            }
            else {
                eval("submenu" + sid + ".style.display=\"none\";");
            }
        }
    </script>
</head>
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <table cellspacing="0" cellpadding="0" width="100%" align="left" border="0">
        <tbody>
            <tr>
                <td valign="top" bgcolor="#799ae1">
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td valign="bottom" height="42">
                                    <img height="38"
                                        src="left.files/title.gif" width="158">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <%--<tr>
                                <td class="menu_title" onmouseover="this.className='menu_title2';"
                                    onmouseout="this.className='menu_title';" background=""
                                    height="25"><span>| <a
                                        href="exit.aspx"
                                        target="_parent"><b>退出</b></a></span></td>
                            </tr>--%>
                            <tr>
                                <td class="menu_title" onmouseover="this.className='menu_title2';"
                                    onmouseout="this.className='menu_title';" background=""
                                    height="25">&nbsp;</td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="menuTitle1"
                                    onmouseover="this.className='menu_title2';" onclick="showsubmenu(0)"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_1.gif"
                                    height="25"><span><b>项目地址</b></span></td>
                            </tr>
                            <tr>
                                <td id="submenu0">
                                    <div class="sec_menu" style="width: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20" class="auto-style1"><a
                                                        href="shenyang.aspx"
                                                        target="mainFrame">沈阳</a></td>
                                                    <td height="20" class="auto-style2"><a
                                                        href="dalian.aspx"
                                                        target="mainFrame">大连</a></td>
                                                    <td height="20"><a
                                                        href="anshan.aspx"
                                                        target="mainFrame">鞍山</a></td>
                                                    <td height="20"><a
                                                        href="fushun.aspx"
                                                        target="mainFrame">抚顺</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20" class="auto-style1"><a
                                                        href="benxi.aspx"
                                                        target="mainFrame">本溪</a></td>
                                                    <td height="20" class="auto-style2"><a
                                                        href="dandong.aspx"
                                                        target="mainFrame">丹东</a></td>
                                                    <td height="20"><a
                                                        href="jinzhou.aspx"
                                                        target="mainFrame">锦州</a></td>
                                                    <td height="20"><a
                                                        href="yingkou.aspx"
                                                        target="mainFrame">营口</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20" class="auto-style1"><a
                                                        href="fuxin.aspx"
                                                        target="mainFrame">阜新</a></td>
                                                    <td height="20" class="auto-style2"><a
                                                        href="liaoyang.aspx"
                                                        target="mainFrame">辽阳</a></td>
                                                    <td height="20"><a
                                                        href="chaoyang.aspx"
                                                        target="mainFrame">朝阳</a></td>
                                                    <td height="20"><a
                                                        href="panjin.aspx"
                                                        target="mainFrame">盘锦</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20" class="auto-style1"><a
                                                        href="tieling.aspx"
                                                        target="mainFrame">铁岭</a></td>
                                                    <td height="20" class="auto-style2"><a
                                                        href="huludao.aspx"
                                                        target="mainFrame">葫芦岛</a></td>
                                                    <td height="20"><a
                                                        href="changtu.aspx"
                                                        target="mainFrame">昌图</a></td>
                                                    <td height="20"><a
                                                        href="suizhong.aspx"
                                                        target="mainFrame">绥中</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div style="width: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20"></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>

                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="menuTitle0"
                                    onmouseover="this.className='menu_title2';" onclick="showsubmenu(2)"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_2.gif" height="25"><span>项目查询</span> </td>
                            </tr>
                            <tr>
                                <td id="submenu2">
                                    <div class="sec_menu" style="width: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                 <tr>
                                                    <td height="20"><a href="../Search/SearchAds.aspx" target="mainFrame">按项目地址查询</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="../Search/SearchName.aspx" target="mainFrame">按项目名查询</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="../Search/SearchTime.aspx" target="mainFrame">按竣工时间查询</a></td>
                                                </tr>
                                                <tr>
                                                    <td height="20"><a href="../Search/SearchType.aspx" target="mainFrame">按热泵类型查询</a></td>
                                                </tr>

                                            </tbody>
                                        </table>
                                    </div>
                                      <div style="width: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20"></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <table cellspacing="0" cellpadding="0" width="158" align="center">
                            <tbody>
                                <tr>
                                    <td class="menu_title" id="menuTitle2"
                                        onmouseover="this.className='menu_title2';" onclick="showsubmenu(3)"
                                        onmouseout="this.className='menu_title';"
                                        background="left.files/admin_left_2.gif" height="25"><span>数据入库</span> </td>
                                </tr>
                                <tr>
                                    <td id="submenu3">
                                        <div class="sec_menu" style="width: 158px">
                                            <table cellspacing="0" cellpadding="0" width="135" align="center">
                                                <tbody>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/ProjectCommonCity.aspx" target="mainFrame">项目基本信息</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/SeaWater.aspx" target="mainFrame">海水源</a></td>
                                                    </tr>
                                                    <tr>                                                       
                                                        <td height="20"><a href="../InputDate/WasteWater.aspx" target="mainFrame">污水源</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/SurfaceWater.aspx" target="mainFrame">地表水 </a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/SoilSource.aspx" target="mainFrame">土壤源</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/UndergroundWater.aspx" target="mainFrame">地下水</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/HSSCP.aspx" target="mainFrame">热源端信息 </a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/USCP.aspx" target="mainFrame">用户端信息</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/WinterType.aspx" target="mainFrame">冬季信息</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/SummerType.aspx" target="mainFrame">夏季信息</a></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="20"><a href="../InputDate/ProjectCost.aspx" target="mainFrame">项目耗资信息</a></td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                          <div style="width: 158px">
                                         <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <table cellspacing="0" cellpadding="0" width="158" align="center">
                            <tbody>
                                <tr>
                                    <td class="menu_title" id="menuTitle4"
                                        onmouseover="this.className='menu_title2';" onclick="showsubmenu(3)"
                                        onmouseout="this.className='menu_title';"
                                        background="left.files/admin_left_2.gif" height="25"><span>系统评估</span> </td>
                                </tr>
                                <tr>
                                    <td id="submenu4">
                                        <div class="sec_menu" style="width: 158px">
                                            <table cellspacing="0" cellpadding="0" width="135" align="center">
                                                <tbody>
                                                     <tr>
                                                        <td class="auto-style3"><a href="../SystemPG/JiZu.aspx" target="mainFrame">机组COP、EER</a></td>
                                                    </tr>    
                                                     <tr>
                                                        <td height="20"><a href="../SystemPG/SystemCE.aspx" target="mainFrame">系统COP、EER</a></td>
                                                    </tr>   
                                                    <tr>
                                                        <td height="20"><a href="../SystemPG/chang.aspx" target="mainFrame">常规能源替代量</a></td>
                                                    </tr>                                                
                                                    <tr>
                                                        <td height="20"><a href="../SystemPG/Huang.aspx" target="mainFrame">环境效益</a></td>
                                                    </tr>     
                                                     <tr>
                                                        <td height="20"><a href="../SystemPG/Jin.aspx" target="mainFrame">经济效益</a></td>
                                                    </tr>                                
                                                     <tr>
                                                        <td class="auto-style3"><a href="../SystemPG/All.aspx" target="mainFrame">总评</a></td>
                                                    </tr>                                                                                           
                                                </tbody>
                                            </table>
                                    </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </table>

                    <table cellspacing="0" cellpadding="0" width="158" align="center">
                        <tbody>
                            <tr>
                                <td class="menu_title" id="menuTitle3"
                                    onmouseover="this.className='menu_title2';"
                                    onmouseout="this.className='menu_title';"
                                    background="left.files/admin_left_9.gif"
                                    height="25"><span>版权信息</span></td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="sec_menu" style="width: 158px">
                                        <table cellspacing="0" cellpadding="0" width="135" align="center">
                                            <tbody>
                                                <tr>
                                                    <td height="20" bgcolor="#D6DFF7" style="line-height: 150%">版权:沈阳建筑大学
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
            </tr>
        </tbody>
    </table>


</body>

</html>
