import React, { Component } from 'react';
//import logo from './logo.svg';
import './App.css';
//import Logbar from './Logbar.js';

class App extends Component {
  render() {
    return (
      <div className="App">
        <Logbar/>
        <div class='row'>
        <ProfessionsTable/>
        <ProfessionTable/>
        <Datepicker/>
        </div>
        <Footerbar/>
      </div>
    );
  }
}

function Logbar(props){
  return <div class='mb-3'>
  			<nav class="navbar navbar-expand-sm bg-dark navbar-dark sticky-top navbar-toggleable-md">
 			<p class='text-white mr-1'>Hello, </p><p class = 'text-white font-weight-bold mr-3' id = 'usernamebar'> anonymous!</p>
   			<div class = "container-fluid justify-content-center align-items-center navbar-collapse collapse ">
                <form class="form-inline" action="/action_page.php">
                    <input class="form-control mr-3" type="text" placeholder="Login"/> 
                    <input class="form-control mr-3" type="text" placeholder="Password"/> 
                    <div>
                    	<button class="btn btn-info mr-3" type="submit">Sign in</button> 
                    	<button class="btn btn-primary" type="submit">Sign up</button> 
                    </div>
				</form>
			</div>
			</nav>  
</div>
}

function ProfessionsTable1(props){
  return  <div class="container col sm-1 md-1 lg-1 xl-1">
            <div class="dropdown">
                <button type="button" class="btn btn-basic dropdown-toggle" data-toggle="dropdown">
                Оберіть професію
                </button>
                <div class="dropdown-menu">    
                      <a class="dropdown-item" href="javascript:void(0)">Стоматолог</a>
                      <a class="dropdown-item" href="javascript:void(0)">Отоларинголог</a>
                      <a class="dropdown-item" href="javascript:void(0)">Терапевт</a>
                      <div class="dropdown-divider"></div>
                      <a class="dropdown-item disabled"  href="javascript:void(0)">Хірург</a>
                      <a class="dropdown-item disabled" href="javascript:void(0)">Кардіолог</a>
                </div>
          </div>
</div>
}

function ProfessionTable1(props){
  return  <div class="container col sm-1 md-1 lg-1 xl-1">
            <div class="dropdown">
                <button type="button" class="btn btn-basic dropdown-toggle" data-toggle="dropdown">
                Оберіть лікаря
                </button>
                <div class="dropdown-menu">    
                      <a class="dropdown-item" href="javascript:void(0)">Лікар 1</a>
                      <a class="dropdown-item" href="javascript:void(0)">Лікар 2</a>
                      <a class="dropdown-item" href="javascript:void(0)">Лікар 3</a>
                </div>
          </div>
</div>
}

function Datepicker(props){
  return <div class="col sm-2 md-9 lg-9 xl-9">
  <div class="container">
      <h2>Поточний розклад:</h2>
      <table class="table table-bordered table-hover table-light">
        <thead>
          <tr>
            <th>-/-</th>
            <th>Sunday</th>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
            <th class = "table-primary">Thursday</th>
            <th>Friday</th>
            <th>Saturday</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <th>09:00-09:30</th>
            <td>-</td>
            <td>-</td>
            <td>-</td>
            <td>-</td>
            <td class = "table-primary">-</td>
            <td>-</td>
            <td>-</td>
          </tr>
          <tr>
                  <th>09:30-10:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>10:00-10:30</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>10:30-11:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>11:00-11:30</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>11:30-12:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>12:00-12:30</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>12:30-13:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td class = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
}

function Footerbar(props){
  return <div>
    <p class='font-italic bg-secondary text-white text-center'>Ніхто ще не скаржився на наш сервіс!</p>
  </div>
}

class ProfessionsTable extends React.Component{
  constructor(){
    super();
    this.state={
      professionsdata: [
        {
          'name': 'Стоматолог',
          'isStatic':true
        },
        {
          'name': 'Отоларинголог',
          'isStatic':true
        },
        {
          'name': 'Терапевт',
          'isStatic':true
        },
        {
          'name': 'Хірург',
          'isStatic':false
        },
        {
          'name': 'Кардіолог',
          'isStatic':false
        } 
      ]
    }
  }
  render(){
    return <div class = "container col sm-1 md-1 lg-1 xl-1 ml-2">
     <h2>Наявні лікарі:</h2>
     <div class="list-group">
      {this.state.professionsdata.map((person, i) => <ProfessionsTableRow key = {i} professionsdata = {person} />)}
     </div>

  </div>
}
}
class ProfessionsTableRow extends React.Component {
  render() {
    var classi = (this.props.professionsdata.isStatic) ? "list-group-item list-group-item-active" : "list-group-item list-group-item-secondary";
     return (
      <a href="javascript:void(0)" class={classi}>{this.props.professionsdata.name}</a>
     );
  }
}
class ProfessionTable extends React.Component{
  constructor(){
    super();
    this.state={
      professiondata:[
        {name : 'Іваненко І. І.'},
        {name : 'Петренко П. П.'},
        {name : 'Міхайлов М. І.'},
        {name : 'Кандидат від. народу.'}
      ]
    }
  };
  render(){
  return  <div class="container col sm-1 md-1 lg-1 xl-1">
                <h2>Оберіть лікаря:</h2>
                <div class="list-group">
                {this.state.professiondata.map((person, i) => <ProfessionTableRow key = {i} professiondata = {person} />)}
                </div>
          </div>
}
}
class ProfessionTableRow extends React.Component {
  
  render() {
    return (
     <a href="javascript:void(0)" class="list-group-item list-group-item-active">{this.props.professiondata.name}</a>
    );     
  }
}

export default App;
