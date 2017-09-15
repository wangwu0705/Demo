using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace GSSystem.DBUtility
{
    public class PageHelper
    {
        public static string GetNumberPage(int pageIndex,int pageCount)
        {
            //构建分类字符串
            StringBuilder sb = new StringBuilder();
            //1 2 3 4 5 
            if (pageCount <= 5)
            {
                if (pageCount <= 5)
                {
                    for (int i = 1; i <= pageCount; i++)
                    {
                        //如果数字是与当前页索引相同，则不加超链接
                        if (pageIndex == i)
                        {
                            sb.Append(i + " ");
                        }
                        else
                        {
                            sb.Append("<a href='?pIndex=" + i + "'>" + i + "</a> ");
                        }
                    }
                }
            }
            else//总页面数大于5
            {
                //1 ... 4 5 6 ...10

                //特例：1，2，最后和倒数第二四个，单独写
                if (pageIndex == 1)//第一页
                {
                    sb.Append("1 ");
                    for (int i = 2; i <= 4; i++)
                    {
                        sb.Append("<a href='?pIndex=" + i + "'>" + i + "</a> ");
                    }
                    sb.Append("... <a href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else if (pageIndex == pageCount)//最后一页
                {
                    sb.Append("<a href='?pIndex=1'>1</a> ... ");
                    for (int i = pageCount - 3; i < pageCount; i++)
                    {
                        sb.Append("<a href='?pIndex=" + i + "'>" + i + "</a> ");
                    }
                    sb.Append(pageCount);
                }
                else if (pageIndex == 2)
                {
                    //1 2 3 4 ...10
                    sb.Append("<a href='?pIndex=1'>1</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append("<a href='?pIndex=3'>3</a> ");
                    sb.Append("<a href='?pIndex=4'>4</a> ");
                    sb.Append("... <a href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else if (pageIndex == 3)
                {
                    //1 2 3 4 ...10
                    sb.Append("<a href='?pIndex=1'>1</a> ");
                    sb.Append("<a href='?pIndex=2'>2</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append("<a href='?pIndex=4'>4</a> ");
                    sb.Append("... <a href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else if (pageIndex == (pageCount - 1))
                {
                    sb.Append("<a href='?pIndex=1'>1</a> ...");
                    sb.Append("<a href='?pIndex=" + (pageIndex - 2) + "'>" + (pageIndex - 2) + "</a> ");
                    sb.Append(" <a href='?pIndex=" + (pageIndex - 1) + "'>" + (pageIndex - 1) + "</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append(" <a href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");

                }
                else if (pageIndex == (pageCount - 2))
                {
                    sb.Append("<a href='?pIndex=1'>1</a> ...");
                    sb.Append("<a href='?pIndex=" + (pageIndex - 1) + "'>" + (pageIndex - 1) + "</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append(" <a href='?pIndex=" + (pageIndex + 1) + "'>" + (pageIndex + 1) + "</a> ");
                    sb.Append(" <a href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else
                {
                    sb.Append("<a href='?pIndex=1'>1</a> ...");
                    sb.Append("<a href='?pIndex=" + (pageIndex - 1) + "'>" + (pageIndex - 1) + "</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append("<a href='?pIndex=" + (pageIndex + 1) + "'>" + (pageIndex + 1) + "</a> ");
                    sb.Append("... <a href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
            }
            return sb.ToString();
        }
    }
}