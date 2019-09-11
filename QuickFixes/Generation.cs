//using System;
//using System.Linq;

//namespace Demo.QuickFixes
//{
//    public class Generation
//    {
//        [Marker]
//        public void A (string str, int i, bool trigger)
//        {
//            IBuilder builder = new Builder(intialValue: $"Start: {str}");
//            builder.Append(trigger);
//            builder.Append(i);

//            string value = builder.Build();
//        }
//    }

//    public interface IBuilder
//    {
//        void Append (bool trigger);
//    }
//}
