import { observer } from "mobx-react-lite";
import React, { Fragment, useEffect, useState } from "react";
import { useStore } from "../store/store";
import { Button, Icon, Dropdown } from "semantic-ui-react";
import { Business } from "../models/business";

const Table = () => {
  const { businessStore } = useStore();

  const [listItems, setListItems] = useState(new Array<Business>());

  const [valueDropdown, setValueDropdown] = useState(1);

  const [sort, setSort] = useState("");

  const headers = [
    { text: "ID", value: "id" },
    { text: "Comercio", value: "name" },
    { text: "CUIT", value: "cuit" },
    { text: "Concepto 1", value: "concept1" },
    { text: "Concepto 2", value: "concept2" },
    { text: "Concepto 3", value: "concept3" },
    { text: "Concepto 4", value: "concept4" },
    { text: "Concepto 5", value: "concept5" },
    { text: "Concepto 6", value: "concept6" },
    { text: "Balance Actual", value: "currentBalance" },
    { text: "Activo", value: "active" },
    { text: "Ultima Venta", value: "lastSale" },
  ];

  const options = [
    { key: 1, text: "Todos", value: 1 },
    { key: 2, text: "Activo", value: 2 },
    { key: 3, text: "Inactivo", value: 3 },
  ];

  useEffect(() => {
    businessStore.getAllBusiness();
  }, [businessStore]);

  useEffect(() => {
    setListItems(businessStore.business);
  }, [businessStore.business]);

  function onSorted(sortBy: string) {
    const Sort = sortBy === "cuit" ? "cuit" : "name";
    const Items = businessStore.business.map((x) => x);
    const Business =
      Sort === sort
        ? businessStore.business
        : Items.sort(function (a, b) {
            var nameA = a[Sort].toUpperCase();
            var nameB = b[Sort].toUpperCase();
            if (nameA < nameB) {
              return -1;
            }
            if (nameA > nameB) {
              return 1;
            }
            return 0;
          });
    Sort === sort ? setSort("") : setSort(Sort);
    setListItems(Business);
  }

  function activeOrNot(event: any, { value }: any) {
    setValueDropdown(value);
    const Filter = value === 1 ? undefined : value === 2 ? true : false;
    const Business =
      Filter === undefined
        ? businessStore.business
        : businessStore.business.filter((x) => x.active === Filter);
    setListItems(Business);
  }

  return (
    <Fragment>
      <h2>Table</h2>
      <Dropdown
        text="Selecciona una opcion"
        onChange={activeOrNot}
        options={options}
        placeholder="Select option"
        selection
        value={valueDropdown}
      />
      <table style={{ width: "100%" }}>
        <thead>
          <tr>
            {headers.map((x, index) => (
              <th key={index}>
                {x.text}
                {(x.value === "name" || x.value === "cuit") && (
                  <Button
                    onClick={() => {
                      onSorted(x.value);
                    }}
                    icon
                  >
                    <Icon name="arrow up" />
                  </Button>
                )}
              </th>
            ))}
          </tr>
        </thead>
        <tbody>
          {listItems.map((x, index) => (
            <tr key={index}>
              <td>{x.id}</td>
              <td>{x.name}</td>
              <td>{x.cuit}</td>
              <td>{x.concept1}</td>
              <td>{x.concept2}</td>
              <td>{x.concept3}</td>
              <td>{x.concept4}</td>
              <td>{x.concept5}</td>
              <td>{x.concept6}</td>
              <td>{x.currentBalance}</td>
              <td>{x.active.toString()}</td>
              <td>{x.lastSale}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </Fragment>
  );
};

export default observer(Table);
