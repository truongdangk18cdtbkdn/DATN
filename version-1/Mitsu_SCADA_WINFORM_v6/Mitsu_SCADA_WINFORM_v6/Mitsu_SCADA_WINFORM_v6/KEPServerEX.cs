namespace Mitsu_SCADA_WINFORM_v6
{
    class KEPServerEX
    {
        public static string[] tagread(int tagnumber)
        {   //-------------Control---------------//
            string tagID_1 = "Channel1.Device1.scadaStart";
            string tagID_2 = "Channel1.Device1.scadaStop";            
            string tagID_3 = "Channel1.Device1.Watchdog";
            string tagID_4 = "Channel1.Device1.scadaLightOn";
            string tagID_5 = "Channel1.Device1.scadaLightOff";
            string tagID_6 = "Channel1.Device1.scadaServo1On";
            string tagID_7 = "Channel1.Device1.scadaServo1Off";
            string tagID_8 = "Channel1.Device1.scadaServo2On";
            string tagID_9 = "Channel1.Device1.scadaServo2Off";
            string tagID_10 = "Channel1.Device1.mStart";
            string tagID_11 = "Channel1.Device1.mStop";
            string tagID_12 = "Channel1.Device1.ledServo1";
            string tagID_13 = "Channel1.Device1.ledServo2";
            string tagID_14 = "Channel1.Device1.ledConveyor";
            string tagID_15 = "Channel1.Device1.ledLight";
            string tagID_16 = "Channel1.Device1.lightTurnOnTime";
            string tagID_17 = "Channel1.Device1.lightTurnOffTime";
            string tagID_18 = "Channel1.Device1.sensor1";
            string tagID_19 = "Channel1.Device1.sensor2";
            string tagID_20 = "Channel1.Device1.typeOfProduct";
            string tagID_21 = "Channel1.Device1.finish";
            string tagID_22 = "Channel1.Device1.finishOFF";

            string[] tags;
            tags = new string[tagnumber];
            tags.SetValue(tagID_1, 1);
            tags.SetValue(tagID_2, 2);
            tags.SetValue(tagID_3, 3);
            tags.SetValue(tagID_4, 4);
            tags.SetValue(tagID_5, 5);
            tags.SetValue(tagID_6, 6);
            tags.SetValue(tagID_7, 7);
            tags.SetValue(tagID_8, 8);
            tags.SetValue(tagID_9, 9);
            tags.SetValue(tagID_10, 10);
            tags.SetValue(tagID_11, 11);
            tags.SetValue(tagID_12, 12);
            tags.SetValue(tagID_13, 13);
            tags.SetValue(tagID_14, 14);
            tags.SetValue(tagID_15, 15);
            tags.SetValue(tagID_16, 16);
            tags.SetValue(tagID_17, 17);
            tags.SetValue(tagID_18, 18);
            tags.SetValue(tagID_19, 19);
            tags.SetValue(tagID_20, 20);
            tags.SetValue(tagID_21, 21);
            tags.SetValue(tagID_22, 22);
            return tags;
        }
        // Make array to read ID tags
        public static int[] tagID(int tagnumber)
        {
            int[] var; 
            var = new int[tagnumber];
            for (int i = 1; i < tagnumber; i++)
            {
                var.SetValue(i, i);
            }
            return var;
        }
    }
}
