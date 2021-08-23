import React, { Fragment } from "react";
import { useStore } from "../store/store";
import { Input, } from 'semantic-ui-react'
import { observer } from "mobx-react-lite";

const Search = () => {
  const { businessStore } = useStore();

  function onEnter(event: any) {
    const FilterToSearch = event.target.value.toLowerCase();
    businessStore.searchBusiness(FilterToSearch);
  }
  
  return (
    <Fragment>
      <h2>Search</h2>
      <Input icon="search" placeholder='Search...' onKeyUp={onEnter} />
      
    </Fragment>
  );
};

export default observer(Search);
