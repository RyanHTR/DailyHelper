﻿#pragma checksum "C:\Users\huitr\Desktop\DailyHelper\DailyHelper\TodosMainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "69C65BD66AFC156DDAC52776A44A7EA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DailyHelper
{
    partial class TodosMainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class TodosMainPage_obj23_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITodosMainPage_Bindings
        {
            private global::DailyHelper.Models.TodoItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj24;
            private global::Windows.UI.Xaml.Controls.TextBlock obj25;

            public TodosMainPage_obj23_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 24:
                        this.obj24 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 25:
                        this.obj25 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::DailyHelper.Models.TodoItem data = args.NewValue as global::DailyHelper.Models.TodoItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::DailyHelper.Models.TodoItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::DailyHelper.Models.TodoItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.UserControl)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DailyHelper.Models.TodoItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // ITodosMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // TodosMainPage_obj23_Bindings

            public void SetDataRoot(global::DailyHelper.Models.TodoItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DailyHelper.Models.TodoItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_source(obj.source, phase);
                        this.Update_title(obj.title, phase);
                    }
                }
            }
            private void Update_source(global::Windows.UI.Xaml.Media.ImageSource obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj24, obj, null);
                }
            }
            private void Update_title(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj25, obj, null);
                }
            }
        }

        private class TodosMainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITodosMainPage_Bindings
        {
            private global::DailyHelper.TodosMainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj21;

            public TodosMainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 21:
                        this.obj21 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // ITodosMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // TodosMainPage_obj1_Bindings

            public void SetDataRoot(global::DailyHelper.TodosMainPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DailyHelper.TodosMainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::DailyHelper.ViewModels.TodoItemViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_AllItems(obj.AllItems, phase);
                    }
                }
            }
            private void Update_ViewModel_AllItems(global::System.Collections.ObjectModel.ObservableCollection<global::DailyHelper.Models.TodoItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj21, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.AddAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 13 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.AddAppBarButton).Click += this.AddAppBarButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.ListStateMin0 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.VisualStateMin500 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.VisualStateMin800 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.TodoList = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.InlineToDoItemViewGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.backpic = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10:
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 11:
                {
                    this.idBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.date = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 15:
                {
                    this.createButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 146 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.createButton).Click += this.createButton_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.CancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 147 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CancelButton).Click += this.CancelButton_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.SelectPictureButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 138 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SelectPictureButton).Click += this.SelectPictureButton_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.TodoScroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 19:
                {
                    this.Query = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    global::Windows.UI.Xaml.Controls.Button element20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 74 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element20).Click += this.BtnGetAll_Click;
                    #line default
                }
                break;
            case 21:
                {
                    this.ToDoListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 75 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ToDoListView).ItemClick += this.TodoItem_ItemClicked;
                    #line default
                }
                break;
            case 22:
                {
                    this.updateTile = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 122 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.updateTile).Click += this.updateTile_Click;
                    #line default
                }
                break;
            case 26:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element26 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 113 "..\..\..\TodosMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element26).Click += this.share_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TodosMainPage_obj1_Bindings bindings = new TodosMainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 23:
                {
                    global::Windows.UI.Xaml.Controls.UserControl element23 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    TodosMainPage_obj23_Bindings bindings = new TodosMainPage_obj23_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::DailyHelper.Models.TodoItem) element23.DataContext);
                    element23.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element23, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
