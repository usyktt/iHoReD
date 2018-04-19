import React from 'react';
import { Component } from 'react';
import $ from 'jquery';
import 'fullcalendar';
/*$(document).ready(function() {
$('#calendar').fullCalendar({
    dayClick: function(date, jsEvent, view) {
  
      alert('Clicked on: ' + date.format());
  
      alert('Coordinates: ' + jsEvent.pageX + ',' + jsEvent.pageY);
  
      alert('Current view: ' + view.name);
  
      // change the day's background color just for fun
      $(this).css('background-color', 'red');
  
    }
  });
});*/

class Calendar extends Component {

    addEvent(newtitle, newstart, newend, newallday) {
        var event={ 
        title  : newtitle,
        start  : newstart,
        end  : newstart,
        allDay : newallday // will make the time show
    };
        $('#calendar').fullCalendar( 'renderEvent', event, true);
    }


    componentDidMount(){
      const { calendar } = this.refs;
  
      $(document).ready(function() {
        // page is ready
        $('#calendar').fullCalendar({
            // enable theme
        theme: true,
        // emphasizes business hours
        businessHours: true,
        // event dragging & resizing
        editable: true,
        // header
        header: {
        left: 'prev,next today',
        center: 'title',
        right: 'month,agendaWeek,agendaDay'
        },
        selectable: true,
        selectHelper: true,
        editable: true,
        select: function(start, end) {
            end =  $.fullCalendar.moment(start);
            end.add(30, 'minutes');
            alert('Clicked on: ' + start.format() + 'to' + end.format());
            $('#calendar').fullCalendar('renderEvent',
            {
                start: start,
                end: end,
                allDay: false
                },
                true // stick the event
            );
            $('#calendar').fullCalendar('unselect');
        },


        events: [
            // all day event
            {
              title  : 'Meeting',
              start  : '2018-04-17'
            },
            // long-term event 
            {
              title  : 'Conference',
              start  : '2018-04-14',
              end    : '2015-11-16'
            },
            // short term event 
            {
              title  : 'Dentist',
              start  : '2018-04-19T11:30:00',
              end  : '2018-04-19T12:30:00',
              allDay : false // will make the time show
            },

            {
                title  : 'ttt',
                start  : '2018-04-19T13:30:00',
                end  : '2018-04-19T16:30:00',
                allDay : false // will make the time show
              },
            {
                title  : 'Dentist',
                start  : '2018-04-19T12:45:00',
                end  : '2018-04-19T13:00:00',
                allDay : false // will make the time show
              },
              {
                title  : 'Dentist',
                start  : '2018-04-19T11:30:00',
                end  : '2018-04-19T12:30:00',
                allDay : false // will make the time show
              },
  
              {
                  title  : 'ttt',
                  start  : '2018-04-19T14:30:00',
                  end  : '2018-04-19T15:30:00',
                  allDay : false // will make the time show
                },
                {
              title  : 'Dentist',
              start  : '2018-04-19T15:30:00',
              end  : '2018-04-19T16:30:00',
              allDay : false // will make the time show
            },

            {
                title  : 'ttt',
                start  : '2018-04-19T16:30:00',
                end  : '2018-04-19T17:45:00',
                allDay : false // will make the time show
            },
            {
                title  : 'Dentist',
                start  : '2018-04-19T17:45:00',
                end  : '2018-04-19T18:00:00',
                allDay : false // will make the time show
            },
            {
                title  : 'ttt',
                start  : '2018-04-19T18:00:00',
                end  : '2018-04-19T18:15:00',
                allDay : false // will make the time show
            },
            {
                title  : 'Dentist',
                start  : '2018-04-19T18:30:00',
                end  : '2018-04-19T19:45:00',
                allDay : false // will make the time show
            },
            {
                title  : 'ttt',
                start  : '2018-04-19T19:45:00',
                end  : '2018-04-19T20:00:00',
                allDay : false // will make the time show
            },
            {
                title  : 'Dentist',
                start  : '2018-04-19T20:00:00',
                end  : '2018-04-19T20:30:00',
                allDay : false // will make the time show
            },
            {
                title  : 'ttt',
                start  : '2018-04-19T20:30:00',
                end  : '2018-04-19T20:45:00',
                allDay : false // will make the time show
            },
            {
                title  : 'Dentist',
                start  : '2018-04-19T21:00:00',
                end  : '2018-04-19T21:15:00',
                allDay : false // will make the time show
            },
            {
                title  : 'ttt',
                start  : '2018-04-19T21:15:00',
                end  : '2018-04-19T21:30:00',
                allDay : false // will make the time show
            },
            {
                title  : 'Dentist',
                start  : '2018-04-19T21:30:00',
                end  : '2018-04-19T21:45:00',
                allDay : false // will make the time show
            }    
          ]
        })
      });
    }
  
    render() {
      return (
        <div id='calendar'></div>
        
      );
    }
  
  }

export default Calendar;