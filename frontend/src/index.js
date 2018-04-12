import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import Diagnoses from './Diagnoses';
import Edit from './Edit';
import StartPatientPage from './StartPatientPage';
import registerServiceWorker from './registerServiceWorker';

ReactDOM.render(<App />, document.getElementById('root'));
registerServiceWorker();

//ReactDOM.render(<Diagnoses />, document.getElementById('root'));
//registerServiceWorker();

//ReactDOM.render(<Edit />, document.getElementById('root'));
//registerServiceWorker();

//ReactDOM.render(<StartPatientPage />, document.getElementById('root'));
//registerServiceWorker();
