(window.__LOADABLE_LOADED_CHUNKS__=window.__LOADABLE_LOADED_CHUNKS__||[]).push([["facebookEnsureInitForDesktop"],{"0K1N":function(e,t,n){t.a=e=>`//connect.facebook.net/${(e=>{const t=e.replace(/-/g,"_");if(t.startsWith("es"))return"es_LA";if(t.startsWith("ar"))return"ar_AR";switch(t){case"de":return"de_DE";case"fr":return"fr_FR";case"it":return"it_IT";case"ja":return"ja_JP";case"nl":return"nl_NL";case"tr":return"tr_TR";case"en_AU":return"en_US";default:return t}})(e)}/sdk.js`},TvzZ:function(e,t,n){n.r(t);var r=n("0K1N"),s=n("eOdZ"),a=n("kmwA"),c=n("37no");let o=!1;const _=(e,t,n="en-US")=>{Object(c.c)(Object(r.a)(n),c.a.FACEBOOK).then(()=>{const n=window.FB;n&&(o||(n.init({appId:a.a.settings.FACEBOOK_API_KEY,status:!0,version:"v2.2"}),FB.Event.subscribe("auth.statusChange",()=>{t()&&_(e=>{if(!e.getUserID())return;const t=e.getAccessToken();if(t){s.a.create("UserSocialNetworkResource",{facebook_token:t}).callUpdate({showError:!1})}},t)}),o=!0,window.fb_init=2),e(n))}),window.fb_init=1};t.default=_}}]);
//# sourceMappingURL=https://sm.pinimg.com/webapp/js/facebookEnsureInitForDesktop-11fe0d493355f796b41f.mjs.map