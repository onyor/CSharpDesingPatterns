using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
        /// <summary>
        /// The 'Visitor' interface
        /// </summary>
        public interface IVisitor
        {
            void Visit(Tablet tablet);
        }
}
