﻿using System;

namespace AbstractFactory
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 10:40:10 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// SqlServerDepartment说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class SqlServerDepartment:IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中给Department表增加了一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL Server中根据ID得到Department表一条记录");
            return null;
        }
    }
}