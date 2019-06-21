using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalIndicator.Core
{

    public interface ICandleStick
    {
        double? High { get; set; }
        double? Low { get; set; }
        double? Open { get; set; }
        double? Close { get; set; }

        double? GetCandleStickPriceReference(CandleStickPriceReferenceEnum candleStickPriceReference);
    }

    public class CandleStick : ICandleStick
    {
        public CandleStick(double? high, double? low, double? open, double? close)
        {
            High = high;
            Low = low;
            Open = open;
            Close = close;
        }

        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Open { get; set; }
        public double? Close { get; set; }


        public double? GetCandleStickPriceReference(CandleStickPriceReferenceEnum candleStickPriceReference)
        {
            if (candleStickPriceReference == CandleStickPriceReferenceEnum.High)
                return this.High;
            if (candleStickPriceReference == CandleStickPriceReferenceEnum.Low)
                return this.Low;
            if (candleStickPriceReference == CandleStickPriceReferenceEnum.Open)
                return this.Open;
            if (candleStickPriceReference == CandleStickPriceReferenceEnum.Close)
                return this.Close;

            throw new Exception("zr: no valid CandleStickPriceReferenceEnum provided. Can't return a candle stick price reference.");
        }

    }





}
