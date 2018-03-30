import React, { Component } from 'react';
//import logo from './logo.svg';
import './App.css';
//import Logbar from './Logbar.js';

class App extends Component {
  render() {
    return (
        <div className="App">
        <Logbar func={this.myfun}/>
        <div className="wrapper container">
        <div className='row'>
        <ProfessionsTable/>
        <ProfessionTable/>
        <Datepicker/>
        </div>
        </div>
        <Footerbar/>
      </div>
    );
  }
}

function Logbar(props){
  return <div className='mb-3'>
  			<nav className="navbar navbar-expand-sm bg-dark navbar-dark sticky-top navbar-toggleable-md">
 			<p className='text-white mr-1'>Hello, </p><p className = 'text-white font-weight-bold mr-3' id = 'usernamebar'> anonymous!</p>
   			<div className = "container-fluid justify-content-center align-items-center navbar-collapse collapse ">
                <form className="form-inline" action="/action_page.php">
                    <input className="form-control mr-3" type="text" placeholder="Login"/> 
                    <input className="form-control mr-3" type="text" placeholder="Password"/> 
                    <div>
                    <button className="btn btn-primary" type="submit">Sign in</button>
                    <button type="button" className="btn btn-primary" data-toggle="modal" data-target="#myModal">Sign up</button> 
                    </div>
                    </form> 
                    </div>
        </nav>            
  <div className="modal fade" id="myModal">
    <div className="modal-dialog">
      <div className="modal-content">
        <div className="modal-header">
          <h4 className="modal-title">Please, fill in the fields to register:</h4>
          <button type="button" className="close" data-dismiss="modal">&times;</button>
        </div>
        <form className="was-validated" noValidate>
  <div className="form-row">
  <div className="form-group col-sm-6 col-xs-12">
      <input type="text" className="form-control" id="inputFName" placeholder="First Name" required/>
      <div className="invalid-tooltip">
        Plese,enter your first name!
      </div>
    </div>
    <div className="form-group col-sm-6 col-xs-12">
      <input type="text" className="form-control" id="inputLName" placeholder="Last Name" required/>
      <div className="invalid-tooltip">
        Plese,enter your last name!
      </div>
    </div>
    <div className="form-group col-sm-6 col-xs-12">
      <input type="email" className="form-control" id="inputEmail4" placeholder="Email" required/>
      <div className="invalid-tooltip">
        Plese,enter valid email!
      </div>
    </div>
    <div className="form-group col-sm-6 col-xs-12">
      <input type="password" className="form-control" id="inputPassword4" placeholder="Password" required/>
      <div className="invalid-tooltip">
        Plese,enter your password!
      </div>
    </div>
    <div className="form-group col-sm-6 col-xs-12">
    <div className="form-check">
      <input className="form-check-input" type="checkbox" id="gridCheck"/>
      <label className="form-check-label" htmlFor="gridCheck">
        Check me out
      </label>
    </div>
  </div>
  <div className="modal-footer">
  <div className="form-group col-sm-6 col-xs-12">
  <div className="container btn-toolbar">
  <div className="row">
  <div className="col-12 col-sm-6 col-md-6">
        <div className="previous">
        <button type="submit" className="btn btn-primary btn-lg mr-5">Sign up
              <span className="glyphicon glyphicon-chevron-left"></span>
          </button>
        </div>
    </div>
    <div className="col-12 col-sm-6 col-md-6">   
        <div className="next">
        <button type="button" className="btn btn-danger btn-lg mr-5" data-dismiss="modal">Close
              <span className="glyphicon glyphicon-chevron-right"></span>
          </button>
        </div>
    </div>
    </div>
        </div>
  </div>
  </div>
  
  </div>
</form>
      </div>
    </div>
  </div> 
</div>
}

function Datepicker(props){
  return <div className="col sm-2 md-9 lg-9 xl-9">
  <div className="container">
      <h2>Поточний розклад:</h2>
      <table className="table table-bordered table-hover table-light">
        <thead>
          <tr>
            <th>-/-</th>
            <th>Sunday</th>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
            <th className = "table-primary">Thursday</th>
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
            <td className = "table-primary">-</td>
            <td>-</td>
            <td>-</td>
          </tr>
          <tr>
                  <th>09:30-10:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>10:00-10:30</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>10:30-11:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>11:00-11:30</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>11:30-12:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>12:00-12:30</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
                  <td>-</td>
                  <td>-</td>
          </tr>
          <tr>
                  <th>12:30-13:00</th>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td>-</td>
                  <td className = "table-primary">-</td>
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
    <p className='font-italic bg-secondary text-white text-center'>Ніхто ще не скаржився на наш сервіс!</p>
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
    return <div className = "container col sm-1 md-1 lg-1 xl-1 ml-2">
     <h2>Наявні лікарі:</h2>
     <div className="list-group">
      {this.state.professionsdata.map((person, i) => <ProfessionsTableRow key = {i} professionsdata = {person} />)}
     </div>

  </div>
}
}
class ProfessionsTableRow extends React.Component {
  render() {
    var classi = (this.props.professionsdata.isStatic) ? "list-group-item list-group-item-active" : "list-group-item list-group-item-secondary";
     return (
      <a href="javascript:void(0)" className={classi}>{this.props.professionsdata.name}</a>
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
  return  <div className="container col sm-1 md-1 lg-1 xl-1">
                <h2>Оберіть лікаря:</h2>
                <div className="list-group">
                {this.state.professiondata.map((person, i) => <ProfessionTableRow key = {i} professiondata = {person} />)}
                </div>
          </div>
}
}
class ProfessionTableRow extends React.Component {
  
  render() {
    return (
     <a href="javascript:void(0)" className="list-group-item list-group-item-active">{this.props.professiondata.name}</a>
    );     
  }
}

export default App;
