import React, { Component } from 'react';
import Calendar from 'react-calendar';
import 'react-calendar/dist/Calendar.css';
import './CalenderView.css';

// const calenderStyle = {
//     width: '100%',
//     background: 'black',
// };

class AdminView extends Component {
  state = {
    date: new Date(),
  }
 
  onChange = date => this.setState({ date })
 
  render() {
    return (
        <container fluid>
            <h1 className="row">Wassup yo!</h1>
            <div className="w-100 row">
                <p>This is your calendar where you input your appointment availability.</p>
            </div>
            <div>
                <Calendar 
                className="w-100 p-5 mt-5"
                onChange={this.onChange}
                value={this.state.date} />
            </div>
            <div className="row border border-dark m-5"></div>
            <div className="row">
                <p>Si, te puedes!</p>
            </div>
      </container>
    );
  }
}

export default AdminView;