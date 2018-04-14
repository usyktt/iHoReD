import React from 'react';
import ReactDOM from 'react-dom';
import { Component } from 'react';
//import { BrowserRouter } from 'react-router-dom';
import { Route, Switch, BrowserRouter, Router} from 'react-router-dom';
import './index.css';
import App from './App';
import Diagnoses from './Diagnoses';
import Edit from './Edit';
import StartPatientPage from './StartPatientPage';
import registerServiceWorker from './registerServiceWorker';

class Home extends Component {
    render() {
      return (
     <Switch>
        <Route exact path="/" component={App}/>
        <Route path="/editUserInfo" component={Edit}/>
        <Route path="/allDiagnoses" component={Diagnoses}/>
        <Route path="/startPage" component={StartPatientPage}/>
      </Switch>
           );
    }
  }

  
  ReactDOM.render((
    <BrowserRouter>
    <Home />
    </BrowserRouter>   )
    , document.getElementById('root'));
  registerServiceWorker();