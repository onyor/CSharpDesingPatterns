using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Factory
{
    /**
     * ToString methodunu ezerek neyi oşturduğumuzu görmüş oluruz.
     */
    public class S8 : IPhone
    {
        private string model;
        private string battery;
        private int width;
        private int height;

        public S8(string model, string battery, int width, int height)
        {
            this.model = model;
            this.battery = battery;
            this.width = width;
            this.height = height;
        }

        public string getBattery()
        {
            return battery;
        }

        public int getHeight()
        {
            return height;
        }

        public string getModel()
        {
            return model;
        }

        public int getWidth()
        {
            return width;
        }

        public override string ToString()
        {
            return "S8( " +
                "model='" + model +'\''+
            ", battery='" + battery + '\'' +
            ", width=" + width +
            ", height=" + height +
            ')';
        }
    }
}
