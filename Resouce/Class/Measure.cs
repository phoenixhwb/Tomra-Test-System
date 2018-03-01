using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Tomra_Test_System.Resouce.Class
{
    class Measure
    {
        public const string MeasureCurrent  = "MeasureCurrent";
        public const string MeasureVoltage  = "MeasureVoltage";
        public const string GenerateVoltage = "GenerateVoltage";
        public const string ManuallyVerify =  "ManuallyVerify";

        private int    ItemNo;
        private bool   ItemVisibility;
        private bool   ItemEnalbe;
        private string ItemName;
        private string ItemMethod;
        private float  ItemLowlimit;
        private float  ItemHighlimit;
        private byte   ItemData1;
        private byte   ItemData2;
        private float  ItemMeasureValue = 0;

        public bool MeasureHandle(DataTable Config,out float MeasureV)
        {
            bool Result = MeasureMethod(ItemMethod, ItemData1, ItemData2);
            MeasureV = ItemMeasureValue;
            return Result;
        }

        public bool MeasureMethod(string mMethod, byte mData1, byte mData2)
        {
            bool Result = false;
            switch (mMethod)
            {
                case MeasureCurrent:
                    Result = FMeasure("Current", ItemLowlimit, ItemHighlimit);
                    break;
                case MeasureVoltage:
                    Result = FMeasure("Voltage", ItemLowlimit, ItemHighlimit);
                    break;
                case GenerateVoltage:
                    Result = FGenerateVoltage(ItemData1, ItemData2);
                    break;
                case ManuallyVerify:
                    Result = FManuallyVerify(ItemData1, ItemData2);
                    break;
            }
            return Result;
        }


        private bool FMeasure(string type,float LowLimit,float HighLimit)
        {
            bool Result = false;
            float MeasureValue =-1;

            switch (type)
            {
                case "Current":
                    MeasureValue = 80;
                    break;
                case "Voltage":
                    MeasureValue = 24;
                    break;
            }

            if (LowLimit >= 0 && HighLimit >= 0)
            {
                if (MeasureValue > LowLimit && MeasureValue < HighLimit)
                    Result = true;
            }
            else if (LowLimit < 0)
            {
                if (MeasureValue < HighLimit)
                    Result = true;
            }
            else if (HighLimit < 0)
            {
                if (MeasureValue > LowLimit)
                    Result = true;
            }
            ItemMeasureValue = MeasureValue;
            return Result;
        }

        private bool FGenerateVoltage(float SetVoltage,float MaxCurrent)
        {
            return true;
            
        }

        private bool FManuallyVerify(byte data1,byte data2)
        {
            ManuallyVerify MV = new ManuallyVerify();

            MV.ShowDialog();

            if (MV.DialogResult == true)
                return true;
            else return false;
            
        }


    }
}
