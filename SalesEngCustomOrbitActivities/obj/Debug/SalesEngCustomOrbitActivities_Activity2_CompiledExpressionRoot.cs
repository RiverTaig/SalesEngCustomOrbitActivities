namespace SalesEngCustomOrbitActivities {
    
    #line 22 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using SE.Orbit.TaskServices;
    
    #line default
    #line hidden
    
    #line 1 "C:\Code\Git\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\SalesEngCustomOrbitActivities\PRPAFollowUp.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Activity2 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Activity2_TypedDataContext2.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext0 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext1 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext2 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext3 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext4 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext4.GetLocation<object>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext5 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext6 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext6.GetLocation<object>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext7 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext8 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext8.GetLocation<object>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext9 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext10 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext10.GetLocation<System.Nullable<System.DateTime>>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext11 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext12 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext12.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext13 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext13.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Activity2_TypedDataContext2(locations, activityContext, true);
                }
                Activity2_TypedDataContext2 refDataContext14 = ((Activity2_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext14.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Activity2_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext2_ForReadOnly valDataContext15 = ((Activity2_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Activity2_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext1_ForReadOnly valDataContext16 = ((Activity2_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext17 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext17.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext18 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext18.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext19 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext20 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext21 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext21.GetLocation<object>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext22 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext23 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext23.GetLocation<object>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext24 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext25 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext25.GetLocation<object>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext26 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext27 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext27.GetLocation<object>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext28 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext29 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext29.GetLocation<System.Nullable<System.DateTime>>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext30 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext31 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext31.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext32 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext32.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Activity2_TypedDataContext3(locations, activityContext, true);
                }
                Activity2_TypedDataContext3 refDataContext33 = ((Activity2_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext33.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Activity2_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 5);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Activity2_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Activity2_TypedDataContext3_ForReadOnly valDataContext34 = ((Activity2_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[4]));
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
                Activity2_TypedDataContext2 refDataContext0 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext0.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Activity2_TypedDataContext2 refDataContext1 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext2 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext3 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Activity2_TypedDataContext2 refDataContext4 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<object>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext5 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Activity2_TypedDataContext2 refDataContext6 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<object>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext7 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Activity2_TypedDataContext2 refDataContext8 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<object>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext9 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Activity2_TypedDataContext2 refDataContext10 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<System.Nullable<System.DateTime>>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext11 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Activity2_TypedDataContext2 refDataContext12 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Activity2_TypedDataContext2 refDataContext13 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                Activity2_TypedDataContext2 refDataContext14 = new Activity2_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                Activity2_TypedDataContext2_ForReadOnly valDataContext15 = new Activity2_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Activity2_TypedDataContext1_ForReadOnly valDataContext16 = new Activity2_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Activity2_TypedDataContext3 refDataContext17 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext17.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Activity2_TypedDataContext3 refDataContext18 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext18.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext19 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext20 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Activity2_TypedDataContext3 refDataContext21 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext21.GetLocation<object>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext22 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Activity2_TypedDataContext3 refDataContext23 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext23.GetLocation<object>(refDataContext23.ValueType___Expr23Get, refDataContext23.ValueType___Expr23Set);
            }
            if ((expressionId == 24)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext24 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Activity2_TypedDataContext3 refDataContext25 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext25.GetLocation<object>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext26 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                Activity2_TypedDataContext3 refDataContext27 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext27.GetLocation<object>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext28 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                Activity2_TypedDataContext3 refDataContext29 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext29.GetLocation<System.Nullable<System.DateTime>>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext30 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Activity2_TypedDataContext3 refDataContext31 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext31.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                Activity2_TypedDataContext3 refDataContext32 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext32.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                Activity2_TypedDataContext3 refDataContext33 = new Activity2_TypedDataContext3(locations, true);
                return refDataContext33.GetLocation<SE.Orbit.TaskServices.TaskResource>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                Activity2_TypedDataContext3_ForReadOnly valDataContext34 = new Activity2_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"FACILITYID\"]") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask.Properties[\"FACILITYID\"]") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"PresentCounter\"]") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask.Properties[\"PrevCounter\"]") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"PresentMeter\"]") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask.Properties[\"PrevMeter\"]") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.CompletionDate.Value.AddMonths(1)") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask.DueDate") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToString(CompletedTask.Owner.Value)") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBStatusTask") 
                        && (Activity2_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity2_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"NeedsRepair\"].ToString() == \"Y\"") 
                        && (Activity2_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"FACILITYID\"]") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask.Properties[\"FACILITYID\"]") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"PresentCounter\"]") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask.Properties[\"PrevCounter\"]") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"PresentMeter\"]") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask.Properties[\"PrevMeter\"]") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.Properties[\"PresentCounter\"]") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask.Properties[\"ReportComments\"]") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask.CompletionDate.Value.AddDays(7)") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask.DueDate") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToString(CompletedTask.Owner.Value)") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "GCBRepairTask") 
                        && (Activity2_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CompletedTask") 
                        && (Activity2_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
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
                return new Activity2_TypedDataContext2(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Activity2_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Activity2_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Activity2_TypedDataContext1_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Activity2_TypedDataContext3(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Activity2_TypedDataContext3_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity2_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Activity2_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Activity2_TypedDataContext1 : Activity2_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
                return Activity2_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity2_TypedDataContext1_ForReadOnly : Activity2_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 165 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          CompletedTask.Properties["NeedsRepair"].ToString() == "Y";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 165 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
          CompletedTask.Properties["NeedsRepair"].ToString() == "Y";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
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
                return Activity2_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity2_TypedDataContext2 : Activity2_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource GCBStatusTask {
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
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 64 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            GCBStatusTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr0Get() {
                
                #line 64 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            GCBStatusTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 64 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
            GCBStatusTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 76 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            GCBStatusTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr1Get() {
                
                #line 76 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            GCBStatusTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 76 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
            GCBStatusTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 84 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
              GCBStatusTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr4Get() {
                
                #line 84 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              GCBStatusTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(object value) {
                
                #line 84 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
              GCBStatusTask.Properties["FACILITYID"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
              GCBStatusTask.Properties["PrevCounter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr6Get() {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              GCBStatusTask.Properties["PrevCounter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(object value) {
                
                #line 96 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
              GCBStatusTask.Properties["PrevCounter"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
              GCBStatusTask.Properties["PrevMeter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr8Get() {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              GCBStatusTask.Properties["PrevMeter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(object value) {
                
                #line 108 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
              GCBStatusTask.Properties["PrevMeter"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 120 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>> expression = () => 
              GCBStatusTask.DueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<System.DateTime> @__Expr10Get() {
                
                #line 120 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              GCBStatusTask.DueDate;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<System.DateTime> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(System.Nullable<System.DateTime> value) {
                
                #line 120 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
              GCBStatusTask.DueDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.Nullable<System.DateTime> value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 133 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            GCBStatusTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr12Get() {
                
                #line 133 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            GCBStatusTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 133 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
            GCBStatusTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 145 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            GCBStatusTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr13Get() {
                
                #line 145 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            GCBStatusTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 145 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
            GCBStatusTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 157 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            GCBStatusTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr14Get() {
                
                #line 157 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            GCBStatusTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 157 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
            GCBStatusTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
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
                if (((locationReferences[(offset + 1)].Name != "GCBStatusTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return Activity2_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity2_TypedDataContext2_ForReadOnly : Activity2_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource GCBStatusTask {
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
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 71 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr2Get() {
                
                #line 71 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 89 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
              CompletedTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr3Get() {
                
                #line 89 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              CompletedTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 101 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
              CompletedTask.Properties["PresentCounter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr5Get() {
                
                #line 101 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              CompletedTask.Properties["PresentCounter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 113 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
              CompletedTask.Properties["PresentMeter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr7Get() {
                
                #line 113 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              CompletedTask.Properties["PresentMeter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 125 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
              CompletedTask.CompletionDate.Value.AddMonths(1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr9Get() {
                
                #line 125 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
              CompletedTask.CompletionDate.Value.AddMonths(1);
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 138 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
            Convert.ToString(CompletedTask.Owner.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 138 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            Convert.ToString(CompletedTask.Owner.Value);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 152 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
            CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr15Get() {
                
                #line 152 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
            CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
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
                if (((locationReferences[(offset + 1)].Name != "GCBStatusTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return Activity2_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity2_TypedDataContext3 : Activity2_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource GCBStatusTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected SE.Orbit.TaskServices.TaskResource GCBRepairTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((2 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 178 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                GCBRepairTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr17Get() {
                
                #line 178 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                GCBRepairTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 178 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                GCBRepairTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 190 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                GCBRepairTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr18Get() {
                
                #line 190 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                GCBRepairTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 190 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                GCBRepairTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 198 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  GCBRepairTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr21Get() {
                
                #line 198 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  GCBRepairTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(object value) {
                
                #line 198 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                  GCBRepairTask.Properties["FACILITYID"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 210 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  GCBRepairTask.Properties["PrevCounter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr23Get() {
                
                #line 210 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  GCBRepairTask.Properties["PrevCounter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr23Set(object value) {
                
                #line 210 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                  GCBRepairTask.Properties["PrevCounter"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr23Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr23Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 222 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  GCBRepairTask.Properties["PrevMeter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr25Get() {
                
                #line 222 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  GCBRepairTask.Properties["PrevMeter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(object value) {
                
                #line 222 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                  GCBRepairTask.Properties["PrevMeter"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 234 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  GCBRepairTask.Properties["ReportComments"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr27Get() {
                
                #line 234 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  GCBRepairTask.Properties["ReportComments"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(object value) {
                
                #line 234 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                  GCBRepairTask.Properties["ReportComments"] = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 247 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>> expression = () => 
                  GCBRepairTask.DueDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<System.DateTime> @__Expr29Get() {
                
                #line 247 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  GCBRepairTask.DueDate;
                
                #line default
                #line hidden
            }
            
            public System.Nullable<System.DateTime> ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(System.Nullable<System.DateTime> value) {
                
                #line 247 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                  GCBRepairTask.DueDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(System.Nullable<System.DateTime> value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 260 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                GCBRepairTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr31Get() {
                
                #line 260 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                GCBRepairTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 260 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                GCBRepairTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                GCBRepairTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr32Get() {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                GCBRepairTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 272 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                GCBRepairTask = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(SE.Orbit.TaskServices.TaskResource value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 284 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                GCBRepairTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr33Get() {
                
                #line 284 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                GCBRepairTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(SE.Orbit.TaskServices.TaskResource value) {
                
                #line 284 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                
                GCBRepairTask = value;
                
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
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "GCBStatusTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "GCBRepairTask") 
                            || (locationReferences[(offset + 2)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return Activity2_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Activity2_TypedDataContext3_ForReadOnly : Activity2_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Activity2_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Activity2_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected SE.Orbit.TaskServices.TaskResource GCBStatusTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected SE.Orbit.TaskServices.TaskResource GCBRepairTask {
                get {
                    return ((SE.Orbit.TaskServices.TaskResource)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 185 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr19Get() {
                
                #line 185 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                CompletedTask;
                
                #line default
                #line hidden
            }
            
            public SE.Orbit.TaskServices.TaskResource ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 203 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr20Get() {
                
                #line 203 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  CompletedTask.Properties["FACILITYID"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 215 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["PresentCounter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr22Get() {
                
                #line 215 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  CompletedTask.Properties["PresentCounter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 227 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["PresentMeter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr24Get() {
                
                #line 227 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  CompletedTask.Properties["PresentMeter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 239 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                  CompletedTask.Properties["PresentCounter"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr26Get() {
                
                #line 239 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  CompletedTask.Properties["PresentCounter"];
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 252 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>> expression = () => 
                  CompletedTask.CompletionDate.Value.AddDays(7);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Nullable<System.DateTime> @__Expr28Get() {
                
                #line 252 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                  CompletedTask.CompletionDate.Value.AddDays(7);
                
                #line default
                #line hidden
            }
            
            public System.Nullable<System.DateTime> ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 265 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                Convert.ToString(CompletedTask.Owner.Value);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 265 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                return 
                Convert.ToString(CompletedTask.Owner.Value);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 279 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
                System.Linq.Expressions.Expression<System.Func<SE.Orbit.TaskServices.TaskResource>> expression = () => 
                CompletedTask;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public SE.Orbit.TaskServices.TaskResource @__Expr34Get() {
                
                #line 279 "C:\CODE\GIT\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\SALESENGCUSTOMORBITACTIVITIES\PRPAFOLLOWUP.XAML"
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
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "GCBStatusTask") 
                            || (locationReferences[(offset + 1)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "GCBRepairTask") 
                            || (locationReferences[(offset + 2)].Type != typeof(SE.Orbit.TaskServices.TaskResource)))) {
                    return false;
                }
                return Activity2_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
