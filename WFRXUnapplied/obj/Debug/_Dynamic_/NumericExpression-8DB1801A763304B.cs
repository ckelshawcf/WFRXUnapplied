//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dynamic.NumericExpression_8DB1801A763304B {
    using System;
    using OpenSpan.TypeManagement;
    
    
    [OpenSpan.TypeManagement.DynamicTypeAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public class Expression {
        
        private Double mResult;
        
        private Double ma;
        
        private Double mb;
        
        public Expression() {
        }
        
        public Double Result {
            get {
                return this.mResult;
            }
        }
        
        public Double a {
            get {
                return this.ma;
            }
            set {
                this.ma = value;
            }
        }
        
        public Double b {
            get {
                return this.mb;
            }
            set {
                this.mb = value;
            }
        }
        
        public void Process() {
            this.mResult = a+b;
        }
    }
}
