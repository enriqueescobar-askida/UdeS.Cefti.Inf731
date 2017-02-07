namespace Common.Lab
{
    public class Lamp
    {
        const int ETEINTE = 0;
        const int BASSE = 1;
        const int MOYENNE = 2;
        const int HAUTE = 3;

        int intensity_;

        public int Intensity
        {
            get { return this.intensity_; }
            set
            {
                if (value > HAUTE)
                {
                    this.intensity_ = 0;
                }
                else
                {
                    this.intensity_ = value;
                }
            }
        }

        public bool IsOn { get; internal set; }

        public int State { get; internal set; }

        public void Plug()
        {
            this.IsOn = true;
        }

        public void Unplug()
        {
            this.IsOn = false;
            this.intensity_ = 0;
        }

        public void Touch()
        {
            if (this.IsOn) this.intensity_++;
        }

        private string FindState()
        {
            if (!this.IsOn) return "OFF";
            else return "OFF";
        }

        private string FindIntensity()
        {
            string s = string.Empty;

            switch (this.intensity_)
            {
                case ETEINTE:
                        s = "is off";
                        break;
                case BASSE:
                        s = "is low";
                        break;
                case MOYENNE:
                        s = "is medium";
                        break;
                case HAUTE:
                        s = "is high";
                        break;
                default:
                        s = "is an error";
                        break;
            }

            return s;
        }

        public override string ToString()
        {
            string currentState = this.FindState();
            string currentIntensity = this.FindIntensity();
            string currentMessage = string.Empty;

            currentMessage = string.Format("La lampe est {0}", currentState);

            if (this.IsOn)
            {
                currentMessage = currentMessage + string.Format(" et elle {0}", currentIntensity);
            }

            return currentMessage;
        }
    }
}
