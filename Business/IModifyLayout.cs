﻿using Landrys.ThePostOak_EpiServer.Models.ViewModels;

namespace Landrys.ThePostOak_EpiServer.Business
{

    /// <summary>
    /// Defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    /// 
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}