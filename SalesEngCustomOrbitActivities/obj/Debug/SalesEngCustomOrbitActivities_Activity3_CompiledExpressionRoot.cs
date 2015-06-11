namespace SalesEngCustomOrbitActivities {
    
    #line 22 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using SE.Orbit.TaskServices;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\NFGLeakReinvestigation.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Activity3 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Activity3_TypedDataContext1_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity3_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext1_ForReadOnly valDataContext0 = ((Activity3_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext1 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext2 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext3 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext4 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext5 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<object>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext6 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext7 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<object>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext8 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext9 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<object>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext10 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext11 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<object>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext12 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext13 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<object>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext14 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext15 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext15.GetLocation<object>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext16 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext17 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<object>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext18 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext19 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<object>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext20 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext21 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext21.GetLocation<object>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext22 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext23 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext23.GetLocation<object>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext24 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext25 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext25.GetLocation<object>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext26 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext27 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext27.GetLocation<System.Nullable<System.DateTime>>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext28 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext29 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext29.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext30 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext30.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext31 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext32 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity3_TypedDataContext2(locations, activityContext, true);
                }
                Activity3_TypedDataContext2 refDataContext33 = ((Activity3_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext33.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity3_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity3_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity3_TypedDataContext2_ForReadOnly valDataContext34 = ((Activity3_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext34.ValueType___Expr34Get();
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
                Activity3_TypedDataContext1_ForReadOnly valDataContext0 = new Activity3_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Activity3_TypedDataContext2 refDataContext1 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Activity3_TypedDataContext2 refDataContext2 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext3 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext4 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Activity3_TypedDataContext2 refDataContext5 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<object>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext6 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Activity3_TypedDataContext2 refDataContext7 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<object>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext8 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Activity3_TypedDataContext2 refDataContext9 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<object>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext10 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                Activity3_TypedDataContext2 refDataContext11 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<object>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext12 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Activity3_TypedDataContext2 refDataContext13 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<object>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext14 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Activity3_TypedDataContext2 refDataContext15 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<object>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext16 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Activity3_TypedDataContext2 refDataContext17 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<object>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext18 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Activity3_TypedDataContext2 refDataContext19 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<object>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext20 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Activity3_TypedDataContext2 refDataContext21 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext21.GetLocation<object>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext22 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Activity3_TypedDataContext2 refDataContext23 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext23.GetLocation<object>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext24 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Activity3_TypedDataContext2 refDataContext25 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext25.GetLocation<object>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext26 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                Activity3_TypedDataContext2 refDataContext27 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext27.GetLocation<System.Nullable<System.DateTime>>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext28 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                Activity3_TypedDataContext2 refDataContext29 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext29.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Activity3_TypedDataContext2 refDataContext30 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext30.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                Activity3_TypedDataContext2 refDataContext31 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext32 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                Activity3_TypedDataContext2 refDataContext33 = new Activity3_TypedDataContext2(locations, true);
                return refDataContext33.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                Activity3_TypedDataContext2_ForReadOnly valDataContext34 = new Activity3_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"FollowUpYN\"].ToString() == \"Y\"") 
                        && (Activity3_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"FACILITYID\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"FACILITYID\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"DateReported\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"DateReported\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"ReportedBy\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"ReportedBy\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"LeakType\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"LeakType\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"EffectOnPublic\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"EffectOnPublic\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"GasReading\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"GasReading\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"LocationReading\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"LocationReading\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"Distance\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"Distance\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"LeakPlastic\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"LeakPlastic\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"Comments\"]") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"Comments\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"RI\"") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.Properties[\"ReportCode\"]") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.CompletionDate.Value.AddYears(1)") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask.DueDate") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToString(CompletedTask.Owner.Value)") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "LeakReportTask") 
                        && (Activity3_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity3_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
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
                return new Activity3_TypedDataContext1_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Activity3_TypedDataContext2(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Activity3_TypedDataContext2_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity3_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity3_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Activity3_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity3_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Activity3_TypedDataContext1 : Activity3_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity3_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return Activity3_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity3_TypedDataContext1_ForReadOnly : Activity3_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity3_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 59 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          CompletedTask.Properties["FollowUpYN"].ToString() == "Y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 59 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
          CompletedTask.Properties["FollowUpYN"].ToString() == "Y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
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
                return Activity3_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity3_TypedDataContext2 : Activity3_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity3_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource LeakReportTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
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
                
                #line 71 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                LeakReportTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr1Get() {
                
                #line 71 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                LeakReportTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 71 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                LeakReportTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 83 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                LeakReportTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr2Get() {
                
                #line 83 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                LeakReportTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 83 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                LeakReportTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 91 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr5Get() {
                
                #line 91 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(object value) {
                
                #line 91 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["FACILITYID"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 103 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["DateReported"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr7Get() {
                
                #line 103 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["DateReported"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(object value) {
                
                #line 103 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["DateReported"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 115 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["ReportedBy"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr9Get() {
                
                #line 115 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["ReportedBy"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(object value) {
                
                #line 115 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["ReportedBy"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 127 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["LeakType"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr11Get() {
                
                #line 127 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["LeakType"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(object value) {
                
                #line 127 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["LeakType"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 139 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["EffectOnPublic"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr13Get() {
                
                #line 139 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["EffectOnPublic"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(object value) {
                
                #line 139 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["EffectOnPublic"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 151 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["GasReading"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr15Get() {
                
                #line 151 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["GasReading"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(object value) {
                
                #line 151 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["GasReading"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 163 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["LocationReading"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr17Get() {
                
                #line 163 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["LocationReading"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(object value) {
                
                #line 163 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["LocationReading"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 175 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["Distance"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr19Get() {
                
                #line 175 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["Distance"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(object value) {
                
                #line 175 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["Distance"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 187 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["LeakPlastic"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr21Get() {
                
                #line 187 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["LeakPlastic"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(object value) {
                
                #line 187 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["LeakPlastic"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 199 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["Comments"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr23Get() {
                
                #line 199 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["Comments"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(object value) {
                
                #line 199 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["Comments"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 211 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  LeakReportTask.Properties["ReportCode"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr25Get() {
                
                #line 211 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.Properties["ReportCode"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(object value) {
                
                #line 211 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.Properties["ReportCode"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 223 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>> expression = () => 
                  LeakReportTask.DueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<System.DateTime> @__Expr27Get() {
                
                #line 223 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  LeakReportTask.DueDate;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<System.DateTime> ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(System.Nullable<System.DateTime> value) {
                
                #line 223 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                  LeakReportTask.DueDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(System.Nullable<System.DateTime> value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 236 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                LeakReportTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr29Get() {
                
                #line 236 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                LeakReportTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 236 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                LeakReportTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 248 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                LeakReportTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr30Get() {
                
                #line 248 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                LeakReportTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 248 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                LeakReportTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 260 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                LeakReportTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr31Get() {
                
                #line 260 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                LeakReportTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 260 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                LeakReportTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                LeakReportTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr33Get() {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                LeakReportTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                
                LeakReportTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "LeakReportTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return Activity3_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity3_TypedDataContext2_ForReadOnly : Activity3_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity3_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity3_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource LeakReportTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
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
                
                #line 78 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr3Get() {
                
                #line 78 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr4Get() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["DateReported"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr6Get() {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["DateReported"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 120 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["ReportedBy"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr8Get() {
                
                #line 120 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["ReportedBy"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 132 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["LeakType"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr10Get() {
                
                #line 132 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["LeakType"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 144 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["EffectOnPublic"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr12Get() {
                
                #line 144 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["EffectOnPublic"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 156 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["GasReading"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr14Get() {
                
                #line 156 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["GasReading"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 168 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["LocationReading"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr16Get() {
                
                #line 168 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["LocationReading"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 180 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["Distance"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr18Get() {
                
                #line 180 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["Distance"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 192 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["LeakPlastic"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr20Get() {
                
                #line 192 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["LeakPlastic"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 204 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["Comments"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr22Get() {
                
                #line 204 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.Properties["Comments"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 216 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  "RI";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr24Get() {
                
                #line 216 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  "RI";
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 228 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
                  CompletedTask.CompletionDate.Value.AddYears(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr26Get() {
                
                #line 228 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                  CompletedTask.CompletionDate.Value.AddYears(1);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 241 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                Convert.ToString(CompletedTask.Owner.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 241 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                Convert.ToString(CompletedTask.Owner.Value);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 255 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr32Get() {
                
                #line 255 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 267 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr34Get() {
                
                #line 267 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\NFGLEAKREINVESTIGATION.XAML"
                return 
                CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "LeakReportTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return Activity3_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
