﻿using System;

[assembly: WebActivator.PreApplicationStartMethod(
    typeof($rootnamespace$.App_Start.MySuperPackage), "PreStart")]

namespace $rootnamespace$.App_Start {
    public static class MySuperPackage {
        public static void PreStart() {
            // Add your start logic here
            
            CatagorizrMvc4.CatagorizrMvc4BootStrapper.Boot();
        }
    }
}