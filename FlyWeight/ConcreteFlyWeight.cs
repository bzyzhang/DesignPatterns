﻿using System;

namespace FlyWeight
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/2 7:23:28 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteFlyWeight说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteFlyWeight : FlyWeight
    {
        public override void Operation(int extrinsticstate)
        {
            Console.WriteLine("具体FlyWeight：" + extrinsticstate);
        }
    }
}