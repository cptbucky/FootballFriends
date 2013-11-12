package com.avantics.footballfriends;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;

/**
 * Created by Tom on 10/11/13.
 */
public class main extends Activity {
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        View vw = getLayoutInflater().inflate(R.layout.main, null);

        // instantiate
        WebView myWebView = (WebView) vw.findViewById(R.id.webview1);

        // enable javascript
        WebSettings webSettings = myWebView.getSettings();
        webSettings.setJavaScriptEnabled(true);

        // allow link clicks to be handled by the web app
        myWebView.setWebViewClient(new WebViewClient());
        myWebView.setWebChromeClient(new WebChromeClient());

        // load web app
        myWebView.loadUrl("http://jumpersforgoalposts.azurewebsites.net/");

        setContentView(vw);
    }
}
