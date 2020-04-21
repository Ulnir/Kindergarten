#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("SU7nnT0PW6s2Gzm+yy5a1y6BlC1Dkx/E8s/qzfHdrg4xwkv1fGoroXOJfrlxT36ZdZOkahJ28eSkos4dBzN9DwLDpbsjlvm+YBg/zZ0znGKCMLOQgr+0u5g0+jRFv7Ozs7eysWioeccrMKV5f35yEi7gzm2HeBv9q0rZbtLn4pYTNefARBvYdNrhn5LCdko/e+mY8ihw0CPOgGSLiO/rrZ9AttUJOVTBDviQEpy6NZYVJtUPjP1nOylfD8j+KzNTAqeqnL9Cm32NC1Tzqs3gB0tcuEZl8nz6B+joE6NyXqon7uL7+LXh4VTxIIa+qjWNMLO9soIws7iwMLOzsh1rfr7DWnDXmq1eMQDqBKSJyZBs4tQtA+Q2BxwK+H86Xgf6k7Cxs7Kz");
        private static int[] order = new int[] { 13,12,7,10,13,8,8,11,13,10,11,11,12,13,14 };
        private static int key = 178;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
