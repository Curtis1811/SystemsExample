using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShopSystem
{
    public static class ShopEventManager
    {
        public delegate void OnShopOpen();
        public static event OnShopOpen onShopOpen;
        public static void DisptachOnShopOpen()
        {
            onShopOpen?.Invoke();
        }



        public delegate void OnShopClose();
        public static event OnShopClose onShopClose;
        public static void DisptachOnShopClose()
        {
            onShopClose?.Invoke();
        }

        

    }

}
