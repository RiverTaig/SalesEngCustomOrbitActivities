namespace SalesEngCustomOrbitActivities {
    
    #line 20 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 21 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 22 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 23 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 24 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 25 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using SE.Orbit.TaskServices;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\GasLeakSurveyCreated.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class GasLeakSurveyCreated : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext0 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new GasLeakSurveyCreated_TypedDataContext2(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2 refDataContext1 = ((GasLeakSurveyCreated_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext2 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new GasLeakSurveyCreated_TypedDataContext2(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2 refDataContext3 = ((GasLeakSurveyCreated_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<System.Collections.Generic.Dictionary<string, string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext4 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext5 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext6 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext7 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext8 = ((GasLeakSurveyCreated_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext0 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                GasLeakSurveyCreated_TypedDataContext2 refDataContext1 = new GasLeakSurveyCreated_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext2 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                GasLeakSurveyCreated_TypedDataContext2 refDataContext3 = new GasLeakSurveyCreated_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<System.Collections.Generic.Dictionary<string, string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext4 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext5 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext6 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext7 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                GasLeakSurveyCreated_TypedDataContext2_ForReadOnly valDataContext8 = new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "CreatedTask") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakSurveyTask") 
                        && (GasLeakSurveyCreated_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Dictionary<string,string>()") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "updateFields") 
                        && (GasLeakSurveyCreated_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "updateFields") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, string>(\"ObjectID\", Convert.ToString(LeakSurveyTask.Prop" +
                            "erties[\"ObjectID\"]))") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "updateFields") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, string>(\"OrbitSurveyStatus\", \"\\\"\"+LeakSurveyTask.Status." +
                            "ToString()+\"\\\"\")") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "updateFields") 
                        && (GasLeakSurveyCreated_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new GasLeakSurveyCreated_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new GasLeakSurveyCreated_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class GasLeakSurveyCreated_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public GasLeakSurveyCreated_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class GasLeakSurveyCreated_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public GasLeakSurveyCreated_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class GasLeakSurveyCreated_TypedDataContext1 : GasLeakSurveyCreated_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public GasLeakSurveyCreated_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource CreatedTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "CreatedTask") 
                            || (locationReferences[(offset + 0)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return GasLeakSurveyCreated_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class GasLeakSurveyCreated_TypedDataContext1_ForReadOnly : GasLeakSurveyCreated_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public GasLeakSurveyCreated_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource CreatedTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "CreatedTask") 
                            || (locationReferences[(offset + 0)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return GasLeakSurveyCreated_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class GasLeakSurveyCreated_TypedDataContext2 : GasLeakSurveyCreated_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public GasLeakSurveyCreated_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource LeakSurveyTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, string> updateFields {
                get {
                    return ((System.Collections.Generic.Dictionary<string, string>)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 62 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
          LeakSurveyTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr1Get() {
                
                #line 62 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          LeakSurveyTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 62 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                
          LeakSurveyTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 74 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, string>>> expression = () => 
          updateFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, string> @__Expr3Get() {
                
                #line 74 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          updateFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, string> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(System.Collections.Generic.Dictionary<string, string> value) {
                
                #line 74 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                
          updateFields = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(System.Collections.Generic.Dictionary<string, string> value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "LeakSurveyTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "updateFields") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.Dictionary<string, string>)))) {
                    return false;
                }
                return GasLeakSurveyCreated_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class GasLeakSurveyCreated_TypedDataContext2_ForReadOnly : GasLeakSurveyCreated_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public GasLeakSurveyCreated_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource LeakSurveyTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, string> updateFields {
                get {
                    return ((System.Collections.Generic.Dictionary<string, string>)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 67 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
          CreatedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr0Get() {
                
                #line 67 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          CreatedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 79 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, string>>> expression = () => 
          new Dictionary<string,string>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, string> @__Expr2Get() {
                
                #line 79 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          new Dictionary<string,string>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, string> ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 90 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>>> expression = () => 
        updateFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> @__Expr4Get() {
                
                #line 90 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
        updateFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 86 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, string>>> expression = () => 
          new KeyValuePair<string, string>("ObjectID", Convert.ToString(LeakSurveyTask.Properties["ObjectID"]));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, string> @__Expr5Get() {
                
                #line 86 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          new KeyValuePair<string, string>("ObjectID", Convert.ToString(LeakSurveyTask.Properties["ObjectID"]));
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, string> ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 100 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>>> expression = () => 
        updateFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> @__Expr6Get() {
                
                #line 100 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
        updateFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, string>>> expression = () => 
          new KeyValuePair<string, string>("OrbitSurveyStatus", "\""+LeakSurveyTask.Status.ToString()+"\"");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, string> @__Expr7Get() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          new KeyValuePair<string, string>("OrbitSurveyStatus", "\""+LeakSurveyTask.Status.ToString()+"\"");
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, string> ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 106 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, string>>> expression = () => 
          updateFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, string> @__Expr8Get() {
                
                #line 106 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\GASLEAKSURVEYCREATED.XAML"
                return 
          updateFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, string> ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "LeakSurveyTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "updateFields") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.Dictionary<string, string>)))) {
                    return false;
                }
                return GasLeakSurveyCreated_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
