#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("XlnwiioYTLwhDC6p3DlNwDmWgzq0ZUm9MPn17O+i9vZD5jeRqb0impUnpIeVqKOsjyPtI1KopKSkoKWmf79u0Dwnsm5oaWUFOffZepBvDOqIV6HCHi5D1hnvhwWLrSKBAjHCGJocQ+S92vcQXEuvUXLla+0Q//8E1WFdKGz+j+U/Z8c02ZdznJ/4/LrAjbpJJhf9E7Oe3od79cM6FPMhEGSeaa5mWGmOYoSzfQVh5vOztdkKvF3OecXw9YEEIvDXUwzPY832iIWb6nAsPkgY3+k8JEQVsL2LqFWMaiekqqWVJ6SvpyekpKUKfGmp1E1nVIQI0+XY/drmyrkZJtVc4mt9PLYQJGoYFdSyrDSB7ql3DyjaiiSLdQsd72gtSRDthKempKWk");
        private static int[] order = new int[] { 13,9,13,8,4,13,11,11,11,13,11,13,12,13,14 };
        private static int key = 165;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
