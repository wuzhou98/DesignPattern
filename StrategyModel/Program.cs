﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么是类?
            //面向对象的编程,并不是类越多越好,类的划分是为了封装,但分类的基础是抽象,
            //具有相同属性和功能的对象的抽象集合才是类。

            //策略模式:
            //它定义了算法家族,分别封装起来,让他们之间可以相互替换,此模式让算法的变化,
            //不会影响到使用算法的客户。
            Context context;
            //通过我们定义的上下文Context传入的对象调用他对应的方法
            //但是我们发现在客服端,会认识到两个类,我们就可以与之前抽象工厂相结合,让用户只认识到一个类
            //改造前:
            //context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();
            //改造后:
            context = new Context("A");
            context.ContextInterface();

            //也许你会疑惑,简单工厂和策略模式到底有什么区别呢？看起来都一样啊!
            //这是我的一些理解
            //1.简单工厂模式:客服端传入一个条件进入工厂类中,工厂类根据条件创建相应的产品创建出对象,
            //并Return给客服端,供客户端使用，即客服端使用的是工厂类生产的产品对象。

            //2.策略模式:客服端穿件一个Context类对象A(可以看作工厂模式中的工厂类),
            //创建一个策略对象并传递并传参给对象A,然后客服端使用A对象的某些方法调用前面参数传进来的策略,即
            //客服端是通过A对象来使用策略。

            //3.为什么两种模式需要结合使用?
            //通过前面的介绍我们可以了解到,简单工厂总的来说就是通过条件创建出具体的对象,而策略模式从侧面来讲他跟简单工厂有着那么几分相识
            //他的工厂类是通过传入的对象来具体的方法，从上面的代码我们发现,如果单一的使用策略模式我们会发现这样客服端就需要认识到两个类，这样耦合性就降低了
            //所以我们就可以将策略模式中Context改造，在他里面具体实例化,而不需要在客户端进行实例化。从而就达到了我们所要的效果。
        }
    }
}