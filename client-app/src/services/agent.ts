import axios, { AxiosResponse } from "axios";
import { Business } from "../models/business";

axios.defaults.baseURL = "http://localhost:5000/api";

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const requests = {
  get: <T>(url: string) => axios.get(url).then(responseBody),
};

const Commerce = {
  list: () => {
    console.log(`${axios.defaults.baseURL}/Business`);
    return requests.get<Business[]>("/Business");
  },
  details: (filter: string) => {
    console.log(`${axios.defaults.baseURL}/Business/${filter}`);
    return requests.get<Business[]>(`/Business/${filter}`);
  },
};

const agent = {
  Commerce,
};

export default agent;
