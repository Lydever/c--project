﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 项目二_实训五_设计十二星座速配系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String c=richTextBox1.Text.Trim();
            switch (c) 
            { 
              case "白羊座":richTextBox1.Text=
                    richTextBox1.Text="最配星座：狮子座 配对指数：100分 配对比重：48：52 配对评语：狮子座注重自己的形象，甚至会有点自恋。不过，他会尽情满足你的浪漫。你们俩将会是合拍的一对。";
                    break;
              case "双鱼座":
                    richTextBox1.Text="最配星座：处女座 配对指数：100分 配对比重：48：52 配对评语：双鱼座与处女座同属于以追求完美为乐，只是一个是浪漫主义，一个是实用主义。所以两个世界里，即可以享受精神上的罗曼蒂克，又可以抓紧荷包，是标准互补型的组合。";
                    break;
              case "狮子座":
                    richTextBox1.Text="最配星座：水瓶座 配对指数：100分 配对比重：48：52 配对评语：爱现的狮子座和自恋的水瓶座，之所以能够搭在一起，是因为他们都可以陶醉在们我想像的情境里，狮子座总以为自贵为王者，而水瓶座则一付“高处不胜寒”的样子，因此，这两个星座滞在一块时，就产生一种“天才总是寂寞”的相惜。";
                    break;
              case "天蝎座":
                    richTextBox1.Text="最配星座：金牛座 配对指数：100分 配对比重：48：52 配对评语：金牛座的和天蝎座都是有高度实践力的星座，更麻烦的是他们的固执程，就像牛魔大战蝎子王，一战三百回合，难分难解。然而角色转换成你侬我侬的情侣时，一个是笨拙的土象星座，一个是阴晦的水象星座，这两个星座组合的潜在诱因在于两个人都有强烈的占有欲，金牛座是吞声忍气，天蝎座是出手就致命，但是因为对方表现的方式不同，而自以为已把对方驯服了。全心全意的爱情，刚好可以满足对方的占有欲。 ";
                    break;
              case "处女座":
                    richTextBox1.Text="最配星座：双鱼座 配对指数：100分 配对比重：48：52 配对评语：双鱼座与处女座同属于以追求完美为乐，只是一个是浪漫主义，一个是实用主义。所以两个世界里，即可以享受精神上的罗曼蒂克，又可以抓紧荷包，是标准互补型的组合。";
                    break;
              case "水瓶座":
                    richTextBox1.Text="最配星座：狮子座 配对指数：100分 配对比重：48：52 配对评语：爱现的狮子座和自恋的水瓶座，之所以能够搭在一起，是因为他们都可以陶醉在们我想像的情境里，狮子座总以为自贵为王者，而水瓶座则一付“高处不胜寒”的样子，因此，这两个星座滞在一块时，就产生一种“天才总是寂寞”的相惜。";
                    break;
              case "射手座":
                    richTextBox1.Text="最配星座：双子座 配对指数：100分 配对比重：48：52 配对评语：这两个奇宝宝的组合，基础建立在彼此都能从求知过程中得到轻劲的快感，所以呢，当双子座遇到射手座，他们之间热线可以从下班烧到晨三点，互投所好，发挥喋喋不休的本能。真所谓良宵苦短，彻夜长谈。 ";
                    break;
              case "双子座":
                    richTextBox1.Text="最配星座：射手座 配对指数：100分 配对比重：48：52 配对评语：这两个奇宝宝的组合，基础建立在彼此都能从求知过程中得到轻劲的快感，所以呢，当双子座遇到射手座，他们之间热线可以从下班烧到晨三点，互投所好，发挥喋喋不休的本能。真所谓良宵苦短，彻夜长谈。 ";
                    break;
              case "金牛座":
                    richTextBox1.Text="最配星座：天蝎座 配对指数：100分 配对比重：48：52 配对评语：金牛座的和天蝎座都是有高度实践力的星座，更麻烦的是他们的固执程，就像牛魔大战蝎子王，一战三百回合，难分难解。然而角色转换成你侬我侬的情侣时，一个是笨拙的土象星座，一个是阴晦的水象星座，这两个星座组合的潜在诱因在于两个人都有强烈的占有欲，金牛座是吞声忍气，天蝎座是出手就致命，但是因为对方表现的方式不同，而自以为已把对方驯服了。全心全意的爱情，刚好可以满足对方的占有欲。 ";
                    break;
              case "天秤座":
                    richTextBox1.Text="最配星座：狮子座 配对指数：100分 配对比重：48：52 配对评语：狮子座注重自己的形象，甚至会有点自恋。不过，他会尽情满足你的浪漫。你们俩将会是合拍的一对。";
                    break;
              case "巨蟹座":
                    richTextBox1.Text="最配星座：摩羯座 配对指数：100分 配对比重：48：52 配对评语：不论是男主外女主内，或者男主内女主外，总之，伴侣之间只要能够分工，就能够在现实社会中筑起一个美满的家庭。顾家的巨蟹座和工作狂摩羯座，可以说是搭配得天衣无缝。老神神在在的摩羯座和婆婆妈妈的巨蟹座，刚好一个扮黑脸，一个演白脸，唱作俱佳。";
                    break;
              case "摩羯座":
                    richTextBox1.Text="最配星座：巨蟹座 配对指数：100分 配对比重：48：52 配对评语：不论是男主外女主内，或者男主内女主外，总之，伴侣之间只要能够分工，就能够在现实社会中筑起一个美满的家庭。顾家的巨蟹座和工作狂摩羯座，可以说是搭配得天衣无缝。老神神在在的摩羯座和婆婆妈妈的巨蟹座，刚好一个扮黑脸，一个演白脸，唱作俱佳。";
                    break;
                    default:
                    richTextBox1.Text="匹配有误!请重新输入!";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }
    }
}
