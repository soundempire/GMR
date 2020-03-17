using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMR.Animation.Animation
{
    public delegate void ControlMethod();
    public class Animation
    {
        public string ID { get; set; }
        public float Value;
        public float startValue;
        public float targetValue;
        public float TargetValue { get => targetValue; set { targetValue = value; reverse = value < Value ? true : false; } }
        public float volume;
        public bool reverse = false;
        private ControlMethod invalidateControl;
        public AnimationStatus Status { get; set; }


        public enum AnimationStatus
        {
            Requested,
            Active,
            Completed
        }
        private float p15, p30, p70, p85;
        public int stepDevider = 11;
        public float Step()
        {
            float basicStep = Math.Abs(volume) / stepDevider;
            float resultStep = 0;

            if (reverse == false)
            {
                if (Value <= p15 || Value >= p85)
                    resultStep = basicStep / 3.5f;
                else if (Value <= p30 || Value >= p70)
                    resultStep = basicStep / 2f;
                else if (Value > p30 && Value < p70)
                    resultStep = basicStep;
            }
            else
            {
                if (Value >= p15 || Value <= p85)
                    resultStep = basicStep / 3.5f;
                else if (Value >= p30 || Value <= p70)
                    resultStep = basicStep / 2f;
                else if (Value < p30 && Value > p70)
                    resultStep = basicStep;
            }
            return Math.Abs(resultStep);
        }

        private float ValueByPercent(float Percent)
        {
            float COEFF = Percent / 100;
            float VolumeInPercent = volume * COEFF;
            float ValueInPercent = startValue + VolumeInPercent;

            return ValueInPercent;
        }

        public void UpdateFrame()
        {
            Status = AnimationStatus.Active;
            if (reverse == false)
            {
                if (Value <= targetValue)
                {
                    Value += Step();
                    if (Value >= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= targetValue)
                {
                    Value -= Step();
                    if (Value <= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            invalidateControl.Invoke();
        }
        public Animation() { }
        public Animation(string id, ControlMethod controlMethod, float val, float tarValue) =>
            (ID, invalidateControl, Value, TargetValue, startValue, volume, p15, p30, p70, p85) =
            (id, controlMethod, val, tarValue, val, (tarValue - val), ValueByPercent(15), ValueByPercent(30), ValueByPercent(70), ValueByPercent(85));


    }
}
