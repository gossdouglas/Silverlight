/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2022
 * @compiler Bridge.NET 17.9.0
 */
Bridge.assembly("OilCanningSilverLightToHtml5Js", function ($asm, globals) {
    "use strict";

    Bridge.define("\u01c0\u01c0Oilcanningsilverlighttohtml5Js\u01c0\u01c0Component\u01c0\u01c0App\u01c0\u01c0Xaml\u01c0\u01c0Factory", {
        statics: {
            methods: {
                Instantiate: function () {
                    var type = OilCanningSilverLightToHtml5Js.App;
                    return Bridge.global.CSHTML5.Internal.TypeInstantiationHelper.Instantiate(type);
                }
            }
        }
    });

    Bridge.define("\u01c0\u01c0Oilcanningsilverlighttohtml5Js\u01c0\u01c0Component\u01c0\u01c0Mainpage\u01c0\u01c0Xaml\u01c0\u01c0Factory", {
        statics: {
            methods: {
                Instantiate: function () {
                    var type = OilCanningSilverLightToHtml5Js.MainPage;
                    return Bridge.global.CSHTML5.Internal.TypeInstantiationHelper.Instantiate(type);
                }
            }
        }
    });

    Bridge.define("OilCanningSilverLightToHtml5Js.App", {
        inherits: [System.Windows.Application],
        main: function Main () {
            new OilCanningSilverLightToHtml5Js.App();
        },
        fields: {
            _contentLoaded: false
        },
        ctors: {
            ctor: function () {
                this.$initialize();
                System.Windows.Application.ctor.call(this);
                this.InitializeComponent();


                var mainPage = new OilCanningSilverLightToHtml5Js.MainPage();
                System.Windows.Window.Current.Content = mainPage;
            }
        },
        methods: {
            InitializeComponent: function () {
                if (this._contentLoaded) {
                    return;
                }
                this._contentLoaded = true;


                if (Bridge.is(this, System.Windows.UIElement)) {
                    Bridge.cast(this, System.Windows.UIElement).XamlSourcePath = "OilCanningSilverLightToHtml5Js\\App.xaml";
                }


                Bridge.global.CSHTML5.Internal.StartupAssemblyInfo.OutputRootPath = "Output\\";
                Bridge.global.CSHTML5.Internal.StartupAssemblyInfo.OutputAppFilesPath = "app-cshtml5\\app\\";
                Bridge.global.CSHTML5.Internal.StartupAssemblyInfo.OutputLibrariesPath = "app-cshtml5\\libs\\";
                Bridge.global.CSHTML5.Internal.StartupAssemblyInfo.OutputResourcesPath = "app-cshtml5\\res\\";


                var ResourceDictionary_79a1c09df59d42e1923383902305a506 = new Bridge.global.System.Windows.ResourceDictionary();
                this.Resources = ResourceDictionary_79a1c09df59d42e1923383902305a506;

                this.Resources = ResourceDictionary_79a1c09df59d42e1923383902305a506;







            }
        }
    });

    Bridge.define("OilCanningSilverLightToHtml5Js.MainPage", {
        inherits: [System.Windows.Controls.Page],
        fields: {
            TextBlock1: null,
            _contentLoaded: false
        },
        ctors: {
            ctor: function () {
                this.$initialize();
                System.Windows.Controls.Page.ctor.call(this);
                this.InitializeComponent();

            }
        },
        methods: {
            InitializeComponent: function () {
                if (this._contentLoaded) {
                    return;
                }
                this._contentLoaded = true;


                if (Bridge.is(this, System.Windows.UIElement)) {
                    Bridge.cast(this, System.Windows.UIElement).XamlSourcePath = "OilCanningSilverLightToHtml5Js\\MainPage.xaml";
                }



                var Canvas_16d195b4a91247a893035449865244ce = new Bridge.global.System.Windows.Controls.Canvas();
                var TextBlock_626e9e3887384d7fa7f2d871c1455258 = new Bridge.global.System.Windows.Controls.TextBlock();
                TextBlock_626e9e3887384d7fa7f2d871c1455258.Text = "Hello World!";
                this.RegisterName$1("TextBlock1", TextBlock_626e9e3887384d7fa7f2d871c1455258);
                TextBlock_626e9e3887384d7fa7f2d871c1455258.Name = "TextBlock1";
                Bridge.global.System.Windows.Controls.Canvas.SetLeft(TextBlock_626e9e3887384d7fa7f2d871c1455258, 20.0);
                Bridge.global.System.Windows.Controls.Canvas.SetTop(TextBlock_626e9e3887384d7fa7f2d871c1455258, 30.0);

                Canvas_16d195b4a91247a893035449865244ce.Children.add(TextBlock_626e9e3887384d7fa7f2d871c1455258);


                this.Content = Canvas_16d195b4a91247a893035449865244ce;



                this.TextBlock1 = TextBlock_626e9e3887384d7fa7f2d871c1455258;



            }
        }
    });
});

//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAiZmlsZSI6ICJPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnMuanMiLAogICJzb3VyY2VSb290IjogIiIsCiAgInNvdXJjZXMiOiBbIm9iai9EZWJ1Zy9BcHAueGFtbC5nLmNzIiwib2JqL0RlYnVnL01haW5QYWdlLnhhbWwuZy5jcyIsIkFwcC54YW1sLmNzIiwiTWFpblBhZ2UueGFtbC5jcyJdLAogICJuYW1lcyI6IFsiIl0sCiAgIm1hcHBpbmdzIjogIjs7Ozs7Ozs7Ozs7O29CQVFRQSxXQUEyQkEsQUFBT0E7b0JBQ2xDQSxPQUFPQSxtRUFBNkRBOzs7Ozs7Ozs7O29CQ0RwRUEsV0FBMkJBLEFBQU9BO29CQUNsQ0EsT0FBT0EsbUVBQTZEQTs7Ozs7Ozs7O1lEbUV4RUEsSUFBSUE7Ozs7Ozs7OztnQkUvRElBOzs7Z0JBSUFBLGVBQWVBLElBQUlBO2dCQUNuQkEsd0NBQXlCQTs7Ozs7Z0JGdUJ6QkEsSUFBSUE7b0JBQ0FBOztnQkFDSkE7OztnQkFHQUEsSUFBSUE7b0JBRUFBLEFBQUNBLFlBQWtDQSxBQUFRQTs7OztnQkFLM0RBO2dCQUNBQTtnQkFDQUE7Z0JBQ0FBOzs7Z0JBR0FBLDBEQUEwREEsSUFBSUE7Z0JBQzlEQSxpQkFBaUJBOztnQkFFakJBLGlCQUFpQkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JHakRMQTs7Ozs7O2dCRjRCQUEsSUFBSUE7b0JBQ0FBOztnQkFDSkE7OztnQkFHQUEsSUFBSUE7b0JBRUFBLEFBQUNBLFlBQWtDQSxBQUFRQTs7Ozs7Z0JBTTNEQSw4Q0FBOENBLElBQUlBO2dCQUNsREEsaURBQWlEQSxJQUFJQTtnQkFDckRBO2dCQUNBQSxrQ0FBZ0NBO2dCQUNoQ0E7Z0JBQ0FBLHFEQUErQ0E7Z0JBQy9DQSxvREFBOENBOztnQkFFOUNBLHFEQUFxREE7OztnQkFHckRBLGVBQWVBOzs7O2dCQUlmQSxrQkFBYUEiLAogICJzb3VyY2VzQ29udGVudCI6IFsiLy8gPENTSFRNTDU+PFhhbWxIYXNoPjkwOTZDNUU5RDVCRTA0NjEwMDQ3M0YxNkE2MzBFNkU3PC9YYW1sSGFzaD48UGFzc051bWJlcj4yPC9QYXNzTnVtYmVyPjxDb21waWxhdGlvbkRhdGU+NS8yNi8yMDIyIDM6MDQ6MzUgUE08L0NvbXBpbGF0aW9uRGF0ZT48L0NTSFRNTDU+XHJcblxyXG5cclxuXHJcbnB1YmxpYyBzdGF0aWMgY2xhc3Mgx4DHgE9pbGNhbm5pbmdzaWx2ZXJsaWdodHRvaHRtbDVKc8eAx4BDb21wb25lbnTHgMeAQXBwx4DHgFhhbWzHgMeARmFjdG9yeVxyXG57XHJcbiAgICBwdWJsaWMgc3RhdGljIG9iamVjdCBJbnN0YW50aWF0ZSgpXHJcbiAgICB7XHJcbiAgICAgICAgZ2xvYmFsOjpTeXN0ZW0uVHlwZSB0eXBlID0gdHlwZW9mKE9pbENhbm5pbmdTaWx2ZXJMaWdodFRvSHRtbDVKcy5BcHApO1xyXG4gICAgICAgIHJldHVybiBnbG9iYWw6OkNTSFRNTDUuSW50ZXJuYWwuVHlwZUluc3RhbnRpYXRpb25IZWxwZXIuSW5zdGFudGlhdGUodHlwZSk7XHJcbiAgICB9XHJcbn1cclxuXHJcbm5hbWVzcGFjZSBPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnNcclxue1xyXG5cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcbi8vIDxhdXRvLWdlbmVyYXRlZD5cclxuLy8gICAgIFRoaXMgY29kZSB3YXMgYXV0by1nZW5lcmF0ZWQgYnkgXCJDIy9YQU1MIGZvciBIVE1MNVwiXHJcbi8vXHJcbi8vICAgICBDaGFuZ2VzIHRvIHRoaXMgZmlsZSBtYXkgY2F1c2UgaW5jb3JyZWN0IGJlaGF2aW9yIGFuZCB3aWxsIGJlIGxvc3QgaWZcclxuLy8gICAgIHRoZSBjb2RlIGlzIHJlZ2VuZXJhdGVkLlxyXG4vLyA8L2F1dG8tZ2VuZXJhdGVkPlxyXG4vLy0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuXHJcblxyXG5wYXJ0aWFsIGNsYXNzIEFwcCA6IGdsb2JhbDo6U3lzdGVtLldpbmRvd3MuQXBwbGljYXRpb25cclxue1xyXG5cclxuI3ByYWdtYSB3YXJuaW5nIGRpc2FibGUgMTY5LCA2NDksIDA2MjggLy8gUHJldmVudHMgd2FybmluZyBDUzAxNjkgKCdmaWVsZCAuLi4gaXMgbmV2ZXIgdXNlZCcpLCBDUzA2NDkgKCdmaWVsZCAuLi4gaXMgbmV2ZXIgYXNzaWduZWQgdG8sIGFuZCB3aWxsIGFsd2F5cyBoYXZlIGl0cyBkZWZhdWx0IHZhbHVlIG51bGwnKSwgYW5kIENTMDYyOCAoJ21lbWJlciA6IG5ldyBwcm90ZWN0ZWQgbWVtYmVyIGRlY2xhcmVkIGluIHNlYWxlZCBjbGFzcycpXHJcblxyXG5cclxuXHJcbiNwcmFnbWEgd2FybmluZyByZXN0b3JlIDE2OSwgNjQ5LCAwNjI4XHJcblxyXG5cclxuICAgICAgICBwcml2YXRlIGJvb2wgX2NvbnRlbnRMb2FkZWQ7XHJcbiAgICAgICAgcHVibGljIHZvaWQgSW5pdGlhbGl6ZUNvbXBvbmVudCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoX2NvbnRlbnRMb2FkZWQpXHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIF9jb250ZW50TG9hZGVkID0gdHJ1ZTtcclxuXHJcbiNwcmFnbWEgd2FybmluZyBkaXNhYmxlIDAxODQgLy8gUHJldmVudHMgd2FybmluZyBDUzAxODQgKCdUaGUgZ2l2ZW4gZXhwcmVzc2lvbiBpcyBuZXZlciBvZiB0aGUgcHJvdmlkZWQgKCd0eXBlJykgdHlwZScpXHJcbiAgICAgICAgICAgIGlmICh0aGlzIGlzIGdsb2JhbDo6U3lzdGVtLldpbmRvd3MuVUlFbGVtZW50KVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAoKGdsb2JhbDo6U3lzdGVtLldpbmRvd3MuVUlFbGVtZW50KShvYmplY3QpdGhpcykuWGFtbFNvdXJjZVBhdGggPSBAXCJPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnNcXEFwcC54YW1sXCI7XHJcbiAgICAgICAgICAgIH1cclxuI3ByYWdtYSB3YXJuaW5nIHJlc3RvcmUgMDE4NFxyXG5cclxuXHJcbmdsb2JhbDo6Q1NIVE1MNS5JbnRlcm5hbC5TdGFydHVwQXNzZW1ibHlJbmZvLk91dHB1dFJvb3RQYXRoID0gQFwiT3V0cHV0XFxcIjtcclxuZ2xvYmFsOjpDU0hUTUw1LkludGVybmFsLlN0YXJ0dXBBc3NlbWJseUluZm8uT3V0cHV0QXBwRmlsZXNQYXRoID0gQFwiYXBwLWNzaHRtbDVcXGFwcFxcXCI7XHJcbmdsb2JhbDo6Q1NIVE1MNS5JbnRlcm5hbC5TdGFydHVwQXNzZW1ibHlJbmZvLk91dHB1dExpYnJhcmllc1BhdGggPSBAXCJhcHAtY3NodG1sNVxcbGlic1xcXCI7XHJcbmdsb2JhbDo6Q1NIVE1MNS5JbnRlcm5hbC5TdGFydHVwQXNzZW1ibHlJbmZvLk91dHB1dFJlc291cmNlc1BhdGggPSBAXCJhcHAtY3NodG1sNVxccmVzXFxcIjtcclxuXHJcblxyXG52YXIgUmVzb3VyY2VEaWN0aW9uYXJ5Xzc5YTFjMDlkZjU5ZDQyZTE5MjMzODM5MDIzMDVhNTA2ID0gbmV3IGdsb2JhbDo6U3lzdGVtLldpbmRvd3MuUmVzb3VyY2VEaWN0aW9uYXJ5KCk7XHJcbnRoaXMuUmVzb3VyY2VzID0gUmVzb3VyY2VEaWN0aW9uYXJ5Xzc5YTFjMDlkZjU5ZDQyZTE5MjMzODM5MDIzMDVhNTA2O1xyXG5cclxudGhpcy5SZXNvdXJjZXMgPSBSZXNvdXJjZURpY3Rpb25hcnlfNzlhMWMwOWRmNTlkNDJlMTkyMzM4MzkwMjMwNWE1MDY7XHJcblxyXG5cclxuXHJcblxyXG5cclxuXHJcbiAgICBcclxuICAgICAgICB9XHJcblxyXG5cclxuXHJcbnB1YmxpYyBzdGF0aWMgdm9pZCBNYWluKClcclxue1xyXG4gICAgbmV3IEFwcCgpO1xyXG59XHJcblxyXG59XHJcblxyXG5cclxufVxyXG4iLCIvLyA8Q1NIVE1MNT48WGFtbEhhc2g+OEQ1NkIzQTVBRDRENzhGNDcxOTAyNjI0MjRDREVBMzQ8L1hhbWxIYXNoPjxQYXNzTnVtYmVyPjI8L1Bhc3NOdW1iZXI+PENvbXBpbGF0aW9uRGF0ZT41LzI2LzIwMjIgMzowNDozNSBQTTwvQ29tcGlsYXRpb25EYXRlPjwvQ1NIVE1MNT5cclxuXHJcblxyXG5cclxucHVibGljIHN0YXRpYyBjbGFzcyDHgMeAT2lsY2FubmluZ3NpbHZlcmxpZ2h0dG9odG1sNUpzx4DHgENvbXBvbmVudMeAx4BNYWlucGFnZceAx4BYYW1sx4DHgEZhY3Rvcnlcclxue1xyXG4gICAgcHVibGljIHN0YXRpYyBvYmplY3QgSW5zdGFudGlhdGUoKVxyXG4gICAge1xyXG4gICAgICAgIGdsb2JhbDo6U3lzdGVtLlR5cGUgdHlwZSA9IHR5cGVvZihPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnMuTWFpblBhZ2UpO1xyXG4gICAgICAgIHJldHVybiBnbG9iYWw6OkNTSFRNTDUuSW50ZXJuYWwuVHlwZUluc3RhbnRpYXRpb25IZWxwZXIuSW5zdGFudGlhdGUodHlwZSk7XHJcbiAgICB9XHJcbn1cclxuXHJcbm5hbWVzcGFjZSBPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnNcclxue1xyXG5cclxuXHJcbi8vLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tXHJcbi8vIDxhdXRvLWdlbmVyYXRlZD5cclxuLy8gICAgIFRoaXMgY29kZSB3YXMgYXV0by1nZW5lcmF0ZWQgYnkgXCJDIy9YQU1MIGZvciBIVE1MNVwiXHJcbi8vXHJcbi8vICAgICBDaGFuZ2VzIHRvIHRoaXMgZmlsZSBtYXkgY2F1c2UgaW5jb3JyZWN0IGJlaGF2aW9yIGFuZCB3aWxsIGJlIGxvc3QgaWZcclxuLy8gICAgIHRoZSBjb2RlIGlzIHJlZ2VuZXJhdGVkLlxyXG4vLyA8L2F1dG8tZ2VuZXJhdGVkPlxyXG4vLy0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxyXG5cclxuXHJcblxyXG5wYXJ0aWFsIGNsYXNzIE1haW5QYWdlIDogZ2xvYmFsOjpTeXN0ZW0uV2luZG93cy5Db250cm9scy5QYWdlXHJcbntcclxuXHJcbiNwcmFnbWEgd2FybmluZyBkaXNhYmxlIDE2OSwgNjQ5LCAwNjI4IC8vIFByZXZlbnRzIHdhcm5pbmcgQ1MwMTY5ICgnZmllbGQgLi4uIGlzIG5ldmVyIHVzZWQnKSwgQ1MwNjQ5ICgnZmllbGQgLi4uIGlzIG5ldmVyIGFzc2lnbmVkIHRvLCBhbmQgd2lsbCBhbHdheXMgaGF2ZSBpdHMgZGVmYXVsdCB2YWx1ZSBudWxsJyksIGFuZCBDUzA2MjggKCdtZW1iZXIgOiBuZXcgcHJvdGVjdGVkIG1lbWJlciBkZWNsYXJlZCBpbiBzZWFsZWQgY2xhc3MnKVxyXG5pbnRlcm5hbCBnbG9iYWw6OlN5c3RlbS5XaW5kb3dzLkNvbnRyb2xzLlRleHRCbG9jayBUZXh0QmxvY2sxO1xyXG5cclxuXHJcbiNwcmFnbWEgd2FybmluZyByZXN0b3JlIDE2OSwgNjQ5LCAwNjI4XHJcblxyXG5cclxuICAgICAgICBwcml2YXRlIGJvb2wgX2NvbnRlbnRMb2FkZWQ7XHJcbiAgICAgICAgcHVibGljIHZvaWQgSW5pdGlhbGl6ZUNvbXBvbmVudCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoX2NvbnRlbnRMb2FkZWQpXHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIF9jb250ZW50TG9hZGVkID0gdHJ1ZTtcclxuXHJcbiNwcmFnbWEgd2FybmluZyBkaXNhYmxlIDAxODQgLy8gUHJldmVudHMgd2FybmluZyBDUzAxODQgKCdUaGUgZ2l2ZW4gZXhwcmVzc2lvbiBpcyBuZXZlciBvZiB0aGUgcHJvdmlkZWQgKCd0eXBlJykgdHlwZScpXHJcbiAgICAgICAgICAgIGlmICh0aGlzIGlzIGdsb2JhbDo6U3lzdGVtLldpbmRvd3MuVUlFbGVtZW50KVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAoKGdsb2JhbDo6U3lzdGVtLldpbmRvd3MuVUlFbGVtZW50KShvYmplY3QpdGhpcykuWGFtbFNvdXJjZVBhdGggPSBAXCJPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnNcXE1haW5QYWdlLnhhbWxcIjtcclxuICAgICAgICAgICAgfVxyXG4jcHJhZ21hIHdhcm5pbmcgcmVzdG9yZSAwMTg0XHJcblxyXG5cclxuXHJcbnZhciBDYW52YXNfMTZkMTk1YjRhOTEyNDdhODkzMDM1NDQ5ODY1MjQ0Y2UgPSBuZXcgZ2xvYmFsOjpTeXN0ZW0uV2luZG93cy5Db250cm9scy5DYW52YXMoKTtcclxudmFyIFRleHRCbG9ja182MjZlOWUzODg3Mzg0ZDdmYTdmMmQ4NzFjMTQ1NTI1OCA9IG5ldyBnbG9iYWw6OlN5c3RlbS5XaW5kb3dzLkNvbnRyb2xzLlRleHRCbG9jaygpO1xyXG5UZXh0QmxvY2tfNjI2ZTllMzg4NzM4NGQ3ZmE3ZjJkODcxYzE0NTUyNTguVGV4dCA9IEBcIkhlbGxvIFdvcmxkIVwiO1xyXG50aGlzLlJlZ2lzdGVyTmFtZShcIlRleHRCbG9jazFcIiwgVGV4dEJsb2NrXzYyNmU5ZTM4ODczODRkN2ZhN2YyZDg3MWMxNDU1MjU4KTtcclxuVGV4dEJsb2NrXzYyNmU5ZTM4ODczODRkN2ZhN2YyZDg3MWMxNDU1MjU4Lk5hbWUgPSBcIlRleHRCbG9jazFcIjtcclxuZ2xvYmFsOjpTeXN0ZW0uV2luZG93cy5Db250cm9scy5DYW52YXMuU2V0TGVmdChUZXh0QmxvY2tfNjI2ZTllMzg4NzM4NGQ3ZmE3ZjJkODcxYzE0NTUyNTgsMjBEKTtcclxuZ2xvYmFsOjpTeXN0ZW0uV2luZG93cy5Db250cm9scy5DYW52YXMuU2V0VG9wKFRleHRCbG9ja182MjZlOWUzODg3Mzg0ZDdmYTdmMmQ4NzFjMTQ1NTI1OCwzMEQpO1xyXG5cclxuQ2FudmFzXzE2ZDE5NWI0YTkxMjQ3YTg5MzAzNTQ0OTg2NTI0NGNlLkNoaWxkcmVuLkFkZChUZXh0QmxvY2tfNjI2ZTllMzg4NzM4NGQ3ZmE3ZjJkODcxYzE0NTUyNTgpO1xyXG5cclxuXHJcbnRoaXMuQ29udGVudCA9IENhbnZhc18xNmQxOTViNGE5MTI0N2E4OTMwMzU0NDk4NjUyNDRjZTtcclxuXHJcblxyXG5cclxuVGV4dEJsb2NrMSA9IFRleHRCbG9ja182MjZlOWUzODg3Mzg0ZDdmYTdmMmQ4NzFjMTQ1NTI1ODtcclxuXHJcblxyXG4gICAgXHJcbiAgICAgICAgfVxyXG5cclxuXHJcblxyXG5cclxufVxyXG5cclxuXHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgU3lzdGVtLklPO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgU3lzdGVtLldpbmRvd3M7XHJcbnVzaW5nIFN5c3RlbS5XaW5kb3dzLkNvbnRyb2xzO1xyXG5cclxubmFtZXNwYWNlIE9pbENhbm5pbmdTaWx2ZXJMaWdodFRvSHRtbDVKc1xyXG57XHJcbiAgICBwdWJsaWMgc2VhbGVkIHBhcnRpYWwgY2xhc3MgQXBwIDogQXBwbGljYXRpb25cclxuICAgIHtcclxuICAgICAgICBwdWJsaWMgQXBwKClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMuSW5pdGlhbGl6ZUNvbXBvbmVudCgpO1xyXG5cclxuICAgICAgICAgICAgLy8gRW50ZXIgY29uc3RydWN0aW9uIGxvZ2ljIGhlcmUuLi5cclxuXHJcbiAgICAgICAgICAgIHZhciBtYWluUGFnZSA9IG5ldyBNYWluUGFnZSgpO1xyXG4gICAgICAgICAgICBXaW5kb3cuQ3VycmVudC5Db250ZW50ID0gbWFpblBhZ2U7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7XHJcbnVzaW5nIFN5c3RlbS5JTztcclxudXNpbmcgU3lzdGVtLkxpbnE7XHJcbnVzaW5nIFN5c3RlbS5XaW5kb3dzO1xyXG51c2luZyBTeXN0ZW0uV2luZG93cy5Db250cm9scztcclxuXHJcbm5hbWVzcGFjZSBPaWxDYW5uaW5nU2lsdmVyTGlnaHRUb0h0bWw1SnNcclxue1xyXG4gICAgcHVibGljIHBhcnRpYWwgY2xhc3MgTWFpblBhZ2UgOiBQYWdlXHJcbiAgICB7XHJcbiAgICAgICAgcHVibGljIE1haW5QYWdlKClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMuSW5pdGlhbGl6ZUNvbXBvbmVudCgpO1xyXG5cclxuICAgICAgICAgICAgLy8gRW50ZXIgY29uc3RydWN0aW9uIGxvZ2ljIGhlcmUuLi5cclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIl0KfQo=
