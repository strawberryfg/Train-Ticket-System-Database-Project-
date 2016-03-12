
import java.io.FileInputStream;
import java.security.KeyStore;
import javax.net.ssl.TrustManager;
import javax.net.ssl.TrustManagerFactory;
import javax.net.ssl.X509TrustManager;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author DELL
 */
public class MyX509TrustManager {
        /*
     * The default X509TrustManager returned by SunX509.  We'll delegate
     * decisions to it, and fall back to the logic in this class if the
     * default X509TrustManager doesn't trust it.
     */
    X509TrustManager sunJSSEX509TrustManager;
    MyX509TrustManager() throws Exception {
        // create a "default" JSSE X509TrustManager.
        KeyStore ks = KeyStore.getInstance("JKS");
        ks.load(new FileInputStream("trustedCerts"),
        "passphrase".toCharArray());
        TrustManagerFactory tmf =
        TrustManagerFactory.getInstance("SunX509", "SunJSSE");
        tmf.init(ks);
        TrustManager tms [] = tmf.getTrustManagers();
        /*
         * Iterate over the returned trustmanagers, look
         * for an instance of X509TrustManager.  If found,
         * use that as our "default" trust manager.
         */
        for (int i = 0; i < tms.length; i++) {
            if (tms[i] instanceof X509TrustManager) {
                sunJSSEX509TrustManager = (X509TrustManager) tms[i];
                return;
            }
        }
        /*
         * Find some other way to initialize, or else we have to fail the
         * constructor.
         */
        throw new Exception("Couldn't initialize");
    }
}
