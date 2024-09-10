﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    public class ValueOutOfRangeExceptions : Exception
    {
        private string m_Message;
        private readonly float m_MaxValue;
        private readonly float m_MinValue;

        public ValueOutOfRangeExceptions(float i_MinValue, float i_MaxValue)
        {
            m_MinValue = i_MinValue;
            m_MaxValue = i_MaxValue;
            m_Message = string.Format("Value is out of range. Please enter a value between {0} to {1}.", i_MinValue, i_MaxValue);
        }

        public override string Message
        {
            get { return m_Message; }
        }
    }
}
