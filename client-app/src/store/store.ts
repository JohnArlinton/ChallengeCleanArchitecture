import { createContext, useContext } from "react";
import BusinessStore from "./businessStore";


interface Store {
    businessStore: BusinessStore
}

export const store: Store = {
    businessStore: new BusinessStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}