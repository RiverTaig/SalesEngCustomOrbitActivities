namespace SalesEngCustomOrbitActivities {
    
    #line 21 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 26 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using SE.Orbit.TaskServices;
    
    #line default
    #line hidden
    
    #line 27 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    #line 28 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 29 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Net;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\CPTestPointReadingTable.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class TestPointReadCompleted : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = TestPointReadCompleted_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TestPointReadCompleted_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext2_ForReadOnly valDataContext0 = ((TestPointReadCompleted_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new TestPointReadCompleted_TypedDataContext2(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext2 refDataContext1 = ((TestPointReadCompleted_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext2 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new TestPointReadCompleted_TypedDataContext4(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4 refDataContext3 = ((TestPointReadCompleted_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext3.GetLocation<System.Collections.Generic.Dictionary<string, string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext4 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext5 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext6 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext7 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext8 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext9 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext10 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new TestPointReadCompleted_TypedDataContext4(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4 refDataContext11 = ((TestPointReadCompleted_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext11.GetLocation<System.Collections.Generic.Dictionary<string, object>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext12 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext13 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext14 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext15 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext16 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext17 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext18 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new TestPointReadCompleted_TypedDataContext4(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4 refDataContext19 = ((TestPointReadCompleted_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext20 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext21 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext22 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext23 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext24 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext25 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext26 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext27 = ((TestPointReadCompleted_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext28 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new TestPointReadCompleted_TypedDataContext3(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3 refDataContext29 = ((TestPointReadCompleted_TypedDataContext3)(cachedCompiledDataContext[5]));
                return refDataContext29.GetLocation<Newtonsoft.Json.Linq.JArray>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext30 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext31 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext32 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext33 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext34 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext35 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new TestPointReadCompleted_TypedDataContext3(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3 refDataContext36 = ((TestPointReadCompleted_TypedDataContext3)(cachedCompiledDataContext[5]));
                return refDataContext36.GetLocation<int>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TestPointReadCompleted_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext37 = ((TestPointReadCompleted_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext37.ValueType___Expr37Get();
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
                TestPointReadCompleted_TypedDataContext2_ForReadOnly valDataContext0 = new TestPointReadCompleted_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                TestPointReadCompleted_TypedDataContext2 refDataContext1 = new TestPointReadCompleted_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext2 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                TestPointReadCompleted_TypedDataContext4 refDataContext3 = new TestPointReadCompleted_TypedDataContext4(locations, true);
                return refDataContext3.GetLocation<System.Collections.Generic.Dictionary<string, string>>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext4 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext5 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext6 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext7 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext8 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext9 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext10 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                TestPointReadCompleted_TypedDataContext4 refDataContext11 = new TestPointReadCompleted_TypedDataContext4(locations, true);
                return refDataContext11.GetLocation<System.Collections.Generic.Dictionary<string, object>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext12 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext13 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext14 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext15 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext16 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext17 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext18 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                TestPointReadCompleted_TypedDataContext4 refDataContext19 = new TestPointReadCompleted_TypedDataContext4(locations, true);
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext20 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext21 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext22 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext23 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext24 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext25 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext26 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                TestPointReadCompleted_TypedDataContext4_ForReadOnly valDataContext27 = new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext28 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                TestPointReadCompleted_TypedDataContext3 refDataContext29 = new TestPointReadCompleted_TypedDataContext3(locations, true);
                return refDataContext29.GetLocation<Newtonsoft.Json.Linq.JArray>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext30 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext31 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext32 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext33 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext34 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext35 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                TestPointReadCompleted_TypedDataContext3 refDataContext36 = new TestPointReadCompleted_TypedDataContext3(locations, true);
                return refDataContext36.GetLocation<int>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            if ((expressionId == 37)) {
                TestPointReadCompleted_TypedDataContext3_ForReadOnly valDataContext37 = new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (TestPointReadCompleted_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CompletedTestPointTask") 
                        && (TestPointReadCompleted_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Dictionary<string,string>()") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "arguments") 
                        && (TestPointReadCompleted_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "arguments") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, string>(\"gdbVersion\", \"\")") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "arguments") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, string>(\"rollbackOnFailure\", \"true\")") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "arguments") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, string>(\"f\", \"json\")") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Dictionary<string,object>()") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, object>(voltArgumentName, CompletedTestPointTask.Propert" +
                            "ies[\"Volts\"])") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, object>(commentsArgumentName, CompletedTestPointTask.Pro" +
                            "perties[\"Comments\"].ToString())") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, object>(\"CPTestPoint_FacID\", CompletedTestPointTask.Prop" +
                            "erties[\"FACILITYID\"].ToString())") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTestPointTask") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CompletedByUpn") 
                        && (TestPointReadCompleted_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, object>(\"READBY\", CompletedByUpn)") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, object>(\"READDATE\", Convert.ToInt64((CompletedTestPointT" +
                            "ask.CompletionDate.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, D" +
                            "ateTimeKind.Utc)).TotalMilliseconds))") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, object>(\"DateReading\", Convert.ToString(CompletedTestPoi" +
                            "ntTask.CompletionDate)+\" (\"+Convert.ToString(CompletedTestPointTask.Properties[\"" +
                            "Volts\"])+\")\")") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFields") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string,object>(globalIDArgumentName, \"{\" + CompletedTestPointTas" +
                            "k.Location.GlobalID.ToString() + \"}\")") 
                        && (TestPointReadCompleted_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new JArray()") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "featuresFieldsJArray") 
                        && (TestPointReadCompleted_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "featuresFieldsJArray") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "JObject.Parse(\"{\\\"attributes\\\":\" + JsonConvert.SerializeObject(featuresFields) + " +
                            "\"}\")") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "arguments") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new KeyValuePair<string, string>(\"features\", JsonConvert.SerializeObject(features" +
                            "FieldsJArray))") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "string.Join(\"&\",arguments.Select(x => string.Format(\"{0}={1}\",\n                We" +
                            "bUtility.UrlEncode(x.Key),\n                WebUtility.UrlEncode(x.Value))))") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "arguments") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CPReadTableRecordObjID") 
                        && (TestPointReadCompleted_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Uri(TestPointTableUrl)") 
                        && (TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
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
                return new TestPointReadCompleted_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new TestPointReadCompleted_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new TestPointReadCompleted_TypedDataContext4(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new TestPointReadCompleted_TypedDataContext4(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new TestPointReadCompleted_TypedDataContext4(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new TestPointReadCompleted_TypedDataContext4_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new TestPointReadCompleted_TypedDataContext3(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new TestPointReadCompleted_TypedDataContext3(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new TestPointReadCompleted_TypedDataContext3_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class TestPointReadCompleted_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class TestPointReadCompleted_TypedDataContext1 : TestPointReadCompleted_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource CompletedTask {
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
                if (((locationReferences[(offset + 0)].Name != "CompletedTask") 
                            || (locationReferences[(offset + 0)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext1_ForReadOnly : TestPointReadCompleted_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource CompletedTask {
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
                if (((locationReferences[(offset + 0)].Name != "CompletedTask") 
                            || (locationReferences[(offset + 0)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext2 : TestPointReadCompleted_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource CompletedTestPointTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string CompletedByUpn {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
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
                
                #line 65 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
          CompletedTestPointTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr1Get() {
                
                #line 65 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
          CompletedTestPointTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 65 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                
          CompletedTestPointTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
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
                if (((locationReferences[(offset + 1)].Name != "CompletedTestPointTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "CompletedByUpn") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext2_ForReadOnly : TestPointReadCompleted_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource CompletedTestPointTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string CompletedByUpn {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
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
                
                #line 70 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
          CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr0Get() {
                
                #line 70 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
          CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
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
                if (((locationReferences[(offset + 1)].Name != "CompletedTestPointTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "CompletedByUpn") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext3 : TestPointReadCompleted_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CPReadTableRecordObjID;
            
            protected int CPReadFeatureObjID;
            
            public TestPointReadCompleted_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Newtonsoft.Json.Linq.JArray featuresFieldsJArray {
                get {
                    return ((Newtonsoft.Json.Linq.JArray)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, string> arguments {
                get {
                    return ((System.Collections.Generic.Dictionary<string, string>)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, object> geometryDictionary {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, object> featuresFields {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string TestPointTableUrl {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string xArgumentName {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected string yArgumentName {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            protected string TestPointFeatureUrl {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 233 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<Newtonsoft.Json.Linq.JArray>> expression = () => 
            featuresFieldsJArray;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Newtonsoft.Json.Linq.JArray @__Expr29Get() {
                
                #line 233 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFieldsJArray;
                
                #line default
                #line hidden
            }
            
            public Newtonsoft.Json.Linq.JArray ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(Newtonsoft.Json.Linq.JArray value) {
                
                #line 233 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                
            featuresFieldsJArray = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(Newtonsoft.Json.Linq.JArray value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 277 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
            CPReadTableRecordObjID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr36Get() {
                
                #line 277 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            CPReadTableRecordObjID;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(int value) {
                
                #line 277 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                
            CPReadTableRecordObjID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.CPReadTableRecordObjID = ((int)(this.GetVariableValue((11 + locationsOffset))));
                this.CPReadFeatureObjID = ((int)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((11 + locationsOffset), this.CPReadTableRecordObjID);
                this.SetVariableValue((12 + locationsOffset), this.CPReadFeatureObjID);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 3)].Name != "featuresFieldsJArray") 
                            || (locationReferences[(offset + 3)].Type != typeof(Newtonsoft.Json.Linq.JArray)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "arguments") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.Dictionary<string, string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "geometryDictionary") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "featuresFields") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TestPointTableUrl") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "xArgumentName") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "yArgumentName") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TestPointFeatureUrl") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "CPReadTableRecordObjID") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "CPReadFeatureObjID") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext3_ForReadOnly : TestPointReadCompleted_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CPReadTableRecordObjID;
            
            protected int CPReadFeatureObjID;
            
            public TestPointReadCompleted_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Newtonsoft.Json.Linq.JArray featuresFieldsJArray {
                get {
                    return ((Newtonsoft.Json.Linq.JArray)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, string> arguments {
                get {
                    return ((System.Collections.Generic.Dictionary<string, string>)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, object> geometryDictionary {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.Dictionary<string, object> featuresFields {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string TestPointTableUrl {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string xArgumentName {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected string yArgumentName {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            protected string TestPointFeatureUrl {
                get {
                    return ((string)(this.GetVariableValue((10 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 238 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<Newtonsoft.Json.Linq.JArray>> expression = () => 
            new JArray();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Newtonsoft.Json.Linq.JArray @__Expr28Get() {
                
                #line 238 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            new JArray();
                
                #line default
                #line hidden
            }
            
            public Newtonsoft.Json.Linq.JArray ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 249 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>>> expression = () => 
          featuresFieldsJArray;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> @__Expr30Get() {
                
                #line 249 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
          featuresFieldsJArray;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 245 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<Newtonsoft.Json.Linq.JToken>> expression = () => 
            JObject.Parse("{\"attributes\":" + JsonConvert.SerializeObject(featuresFields) + "}");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Newtonsoft.Json.Linq.JToken @__Expr31Get() {
                
                #line 245 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            JObject.Parse("{\"attributes\":" + JsonConvert.SerializeObject(featuresFields) + "}");
                
                #line default
                #line hidden
            }
            
            public Newtonsoft.Json.Linq.JToken ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 259 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>>> expression = () => 
          arguments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> @__Expr32Get() {
                
                #line 259 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
          arguments;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 255 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, string>>> expression = () => 
            new KeyValuePair<string, string>("features", JsonConvert.SerializeObject(featuresFieldsJArray));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, string> @__Expr33Get() {
                
                #line 255 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            new KeyValuePair<string, string>("features", JsonConvert.SerializeObject(featuresFieldsJArray));
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, string> ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 264 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          string.Join("&",arguments.Select(x => string.Format("{0}={1}",
                WebUtility.UrlEncode(x.Key),
                WebUtility.UrlEncode(x.Value))));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 264 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
          string.Join("&",arguments.Select(x => string.Format("{0}={1}",
                WebUtility.UrlEncode(x.Key),
                WebUtility.UrlEncode(x.Value))));
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, string>>> expression = () => 
            arguments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, string> @__Expr35Get() {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            arguments;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, string> ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 282 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Uri>> expression = () => 
            new Uri(TestPointTableUrl);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Uri @__Expr37Get() {
                
                #line 282 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            new Uri(TestPointTableUrl);
                
                #line default
                #line hidden
            }
            
            public System.Uri ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            protected override void GetValueTypeValues() {
                this.CPReadTableRecordObjID = ((int)(this.GetVariableValue((11 + locationsOffset))));
                this.CPReadFeatureObjID = ((int)(this.GetVariableValue((12 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 13))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 13);
                }
                expectedLocationsCount = 13;
                if (((locationReferences[(offset + 3)].Name != "featuresFieldsJArray") 
                            || (locationReferences[(offset + 3)].Type != typeof(Newtonsoft.Json.Linq.JArray)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "arguments") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Collections.Generic.Dictionary<string, string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "geometryDictionary") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "featuresFields") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "TestPointTableUrl") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "xArgumentName") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "yArgumentName") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "TestPointFeatureUrl") 
                            || (locationReferences[(offset + 10)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "CPReadTableRecordObjID") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "CPReadFeatureObjID") 
                            || (locationReferences[(offset + 12)].Type != typeof(int)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext4 : TestPointReadCompleted_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string voltArgumentName {
                get {
                    return ((string)(this.GetVariableValue((13 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((13 + locationsOffset), value);
                }
            }
            
            protected string commentsArgumentName {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((14 + locationsOffset), value);
                }
            }
            
            protected string globalIDArgumentName {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((15 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, string>>> expression = () => 
              arguments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, string> @__Expr3Get() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              arguments;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, string> ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(System.Collections.Generic.Dictionary<string, string> value) {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                
              arguments = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(System.Collections.Generic.Dictionary<string, string> value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 138 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, object>>> expression = () => 
              featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, object> @__Expr11Get() {
                
                #line 138 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, object> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Collections.Generic.Dictionary<string, object> value) {
                
                #line 138 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                
              featuresFields = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.Generic.Dictionary<string, object> value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 180 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              CompletedByUpn;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 180 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              CompletedByUpn;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(string value) {
                
                #line 180 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                
              CompletedByUpn = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 13)].Name != "voltArgumentName") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "commentsArgumentName") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "globalIDArgumentName") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TestPointReadCompleted_TypedDataContext4_ForReadOnly : TestPointReadCompleted_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TestPointReadCompleted_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TestPointReadCompleted_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string voltArgumentName {
                get {
                    return ((string)(this.GetVariableValue((13 + locationsOffset))));
                }
            }
            
            protected string commentsArgumentName {
                get {
                    return ((string)(this.GetVariableValue((14 + locationsOffset))));
                }
            }
            
            protected string globalIDArgumentName {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 101 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, string>>> expression = () => 
              new Dictionary<string,string>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, string> @__Expr2Get() {
                
                #line 101 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
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
                
                #line 112 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>>> expression = () => 
            arguments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> @__Expr4Get() {
                
                #line 112 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            arguments;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, string>>> expression = () => 
              new KeyValuePair<string, string>("gdbVersion", "");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, string> @__Expr5Get() {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, string>("gdbVersion", "");
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, string> ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 122 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>>> expression = () => 
            arguments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> @__Expr6Get() {
                
                #line 122 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            arguments;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 118 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, string>>> expression = () => 
              new KeyValuePair<string, string>("rollbackOnFailure", "true");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, string> @__Expr7Get() {
                
                #line 118 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, string>("rollbackOnFailure", "true");
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, string> ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 132 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>>> expression = () => 
            arguments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> @__Expr8Get() {
                
                #line 132 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            arguments;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>> ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 128 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, string>>> expression = () => 
              new KeyValuePair<string, string>("f", "json");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, string> @__Expr9Get() {
                
                #line 128 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, string>("f", "json");
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, string> ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 143 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.Dictionary<string, object>>> expression = () => 
              new Dictionary<string,object>();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.Dictionary<string, object> @__Expr10Get() {
                
                #line 143 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new Dictionary<string,object>();
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.Dictionary<string, object> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 154 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr12Get() {
                
                #line 154 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 150 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string, object>(voltArgumentName, CompletedTestPointTask.Properties["Volts"]);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr13Get() {
                
                #line 150 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, object>(voltArgumentName, CompletedTestPointTask.Properties["Volts"]);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 164 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr14Get() {
                
                #line 164 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 160 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string, object>(commentsArgumentName, CompletedTestPointTask.Properties["Comments"].ToString());
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr15Get() {
                
                #line 160 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, object>(commentsArgumentName, CompletedTestPointTask.Properties["Comments"].ToString());
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 174 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr16Get() {
                
                #line 174 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 170 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string, object>("CPTestPoint_FacID", CompletedTestPointTask.Properties["FACILITYID"].ToString());
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr17Get() {
                
                #line 170 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, object>("CPTestPoint_FacID", CompletedTestPointTask.Properties["FACILITYID"].ToString());
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 185 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
              CompletedTestPointTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr18Get() {
                
                #line 185 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              CompletedTestPointTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 196 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr20Get() {
                
                #line 196 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 192 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string, object>("READBY", CompletedByUpn);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr21Get() {
                
                #line 192 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, object>("READBY", CompletedByUpn);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 206 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr22Get() {
                
                #line 206 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 202 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string, object>("READDATE", Convert.ToInt64((CompletedTestPointTask.CompletionDate.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr23Get() {
                
                #line 202 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, object>("READDATE", Convert.ToInt64((CompletedTestPointTask.CompletionDate.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds));
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 216 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr24Get() {
                
                #line 216 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 212 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string, object>("DateReading", Convert.ToString(CompletedTestPointTask.CompletionDate)+" ("+Convert.ToString(CompletedTestPointTask.Properties["Volts"])+")");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr25Get() {
                
                #line 212 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string, object>("DateReading", Convert.ToString(CompletedTestPointTask.CompletionDate)+" ("+Convert.ToString(CompletedTestPointTask.Properties["Volts"])+")");
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 226 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>>> expression = () => 
            featuresFields;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> @__Expr26Get() {
                
                #line 226 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
            featuresFields;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>> ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 222 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.KeyValuePair<string, object>>> expression = () => 
              new KeyValuePair<string,object>(globalIDArgumentName, "{" + CompletedTestPointTask.Location.GlobalID.ToString() + "}");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.KeyValuePair<string, object> @__Expr27Get() {
                
                #line 222 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\CPTESTPOINTREADINGTABLE.XAML"
                return 
              new KeyValuePair<string,object>(globalIDArgumentName, "{" + CompletedTestPointTask.Location.GlobalID.ToString() + "}");
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.KeyValuePair<string, object> ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 16))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 16);
                }
                expectedLocationsCount = 16;
                if (((locationReferences[(offset + 13)].Name != "voltArgumentName") 
                            || (locationReferences[(offset + 13)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "commentsArgumentName") 
                            || (locationReferences[(offset + 14)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "globalIDArgumentName") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                return TestPointReadCompleted_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
