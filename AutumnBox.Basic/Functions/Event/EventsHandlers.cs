﻿/*
 @zsh2401 2017/9/6
 事件的处理方法
 */
namespace AutumnBox.Basic.Functions.Event
{
    public delegate void StartEventHandler(object sender, StartEventArgs e = null);
    public delegate void FinishEventHandler(object sender,FinishEventArgs e=null);
    public delegate void SimpleFinishEventHandler();
    public delegate void RunningManagerFinishHandler(object sender,RMFinishEventArgs e);
}