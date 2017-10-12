using System;

namespace K_Factor_Shared
{
    public static class Constants
    {
        public static string AppTitle = "Prusa K-Factor Test Generator";
        
        public static string TemplateString = ";K Line Test created by Sebastianv650" + Environment.NewLine + 
                                                "" + Environment.NewLine + 
                                                "M107" + Environment.NewLine + 
                                                "M83  ; extruder relative mode" + Environment.NewLine + 
                                                "M104 S{0} ; set extruder temp" + Environment.NewLine + 
                                                "M140 S{1} ; set bed temp" + Environment.NewLine + 
                                                "M190 S{1} ; wait for bed temp" + Environment.NewLine + 
                                                "M109 S{0} ; wait for extruder temp" + Environment.NewLine + 
                                                "G28 W ; home all without mesh bed level" + Environment.NewLine + 
                                                "G80 ; mesh bed leveling" + Environment.NewLine + 
                                                "G1 Y-3.0 F1000.0 ; go outside print area" + Environment.NewLine + 
                                                "G1 X60.0 E9.0  F1000.0 ; intro line" + Environment.NewLine + 
                                                "G1 X100.0 E12.5  F1000.0 ; intro line" + Environment.NewLine + 
                                                "G21 ; set units to millimeters" + Environment.NewLine + 
                                                "G90 ; use absolute coordinates" + Environment.NewLine + 
                                                "M83 ; use relative distances for extrusion" + Environment.NewLine + 
                                                "G1 Z0.200 F7200.000" + Environment.NewLine + 
                                                "M204 S500" + Environment.NewLine + 
                                                ";20mm/s = F1200" + Environment.NewLine + 
                                                ";70mm/s = F4200" + Environment.NewLine + 
                                                ";120mm/s = F7200" + Environment.NewLine + 
                                                "G1 E-0.80000 F2100.00000" + Environment.NewLine + 
                                                "G1 X10 Y10 F7200.000" + Environment.NewLine + 
                                                "G1 E0.80000 F2100.00000" + Environment.NewLine + 
                                                "M900 K{2}" + Environment.NewLine + 
                                                "G1 X10 Y20 E0.37418 F1200 ;Prime, travel to first testline" + Environment.NewLine + 
                                                "G1 X30 Y20 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X60 Y20 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X80 Y20 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{3}" + Environment.NewLine + 
                                                "G1 X80 Y30 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X60 Y30 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X30 Y30 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X10 Y30 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{4}" + Environment.NewLine + 
                                                "G1 X10 Y40 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X30 Y40 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X60 Y40 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X80 Y40 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{5}" + Environment.NewLine + 
                                                "G1 X80 Y50 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X60 Y50 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X30 Y50 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X10 Y50 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{6}" + Environment.NewLine + 
                                                "G1 X10 Y60 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X30 Y60 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X60 Y60 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X80 Y60 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{7}" + Environment.NewLine + 
                                                "G1 X80 Y70 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X60 Y70 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X30 Y70 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X10 Y70 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{8}" + Environment.NewLine + 
                                                "G1 X10 Y80 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X30 Y80 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X60 Y80 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X80 Y80 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{9}" + Environment.NewLine + 
                                                "G1 X80 Y90 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X60 Y90 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X30 Y90 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X10 Y90 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "M900 K{10}" + Environment.NewLine + 
                                                "G1 X10 Y100 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
                                                "G1 X30 Y100 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
                                                "G1 X60 Y100 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
                                                "G1 X80 Y100 E0.74835 F1200 ;Slow part" + Environment.NewLine +
                                                "M900 K{11}" + Environment.NewLine +
                                                "G1 X80 Y110 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine +
                                                "G1 X60 Y110 E0.74835 F1200 ;Slow part" + Environment.NewLine +
                                                "G1 X30 Y110 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine +
                                                "G1 X10 Y110 E0.74835 F1200 ;Slow part" + Environment.NewLine +
                                                "M900 K{12}" + Environment.NewLine +
                                                "G1 X10 Y120 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine +
                                                "G1 X30 Y120 E0.74835 F1200 ;Slow part" + Environment.NewLine +
                                                "G1 X60 Y120 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine +
                                                "G1 X80 Y120 E0.74835 F1200 ;Slow part" + Environment.NewLine +
            
            //"M900 K{11}" + Environment.NewLine + 
            //                                  "G1 X80 Y110 E0.37418 F1200 ;Travel to next testline" + Environment.NewLine + 
            //                                "G1 X60 Y110 E0.74835 F1200 ;Slow part" + Environment.NewLine + 
            //                              "G1 X30 Y110 E1.12253 F4200 ;Accelerate - cruise - decelerate" + Environment.NewLine + 
            //                            "G1 X10 Y110 E0.74835 F1200 ;Slow part" + Environment.NewLine + 



                                                "G1 E-0.80000 F2100.00000" + Environment.NewLine + 
                                                "M107" + Environment.NewLine + 
                                                "G4 ; wait" + Environment.NewLine + 
                                                "M104 S0 ; turn off temperature" + Environment.NewLine + 
                                                "M140 S0 ; turn off heatbed" + Environment.NewLine + 
                                                "M107 ; turn off fan" + Environment.NewLine + 
                                                "G91; relative cooridantes" + Environment.NewLine + 
                                                "G1 Z1 F4500;" + Environment.NewLine + 
                                                "G90; set absolute coordinates" + Environment.NewLine + 
                                                "G1 X0 Y200; home X axis" + Environment.NewLine + 
                                                "M84 ; disable motors";
    }
}
