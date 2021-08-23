import { makeAutoObservable, runInAction } from "mobx";
import { Business } from "../models/business";
import agent from "../services/agent";

export default class BusinessStore {
  business: Business[] = [];

  constructor() {
    makeAutoObservable(this);
  }

  getAllBusiness = async () => {
    try {
      const business = await agent.Commerce.list();
      runInAction(() => {
        business.forEach((x: Business) => {
          x.lastSale = x.lastSale.split("T")[0];
          this.business.push(x);
        });
      });
    } catch (error) {
      console.log(error);
    }
  };

  searchBusiness = async (filter: string) => {
    try {
      this.business = await agent.Commerce.details(filter);
      runInAction(() => {
          this.business.push()
      });
    } catch (error) {
      console.log(error);
    }
  };
}
