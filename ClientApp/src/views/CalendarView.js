// import React, { useState } from 'react';
// import Calendar from 'react-calendar';
// // import Calendar from "../components/Calendar";

// const CalendarView = () => {
//     let date = new Date();
//     const [state, setState ] = useState(Date(2020, 1, 1));

//     const onChange = date => setState({ date })
        
//     return (
//         <div className="w-100 row">
//             <Calendar 
//             onChange={onChange}
//             value={state.date} />
//         </div>
//     );
// }

// export default CalendarView;

import React, { Component } from 'react';
import Calendar from 'react-calendar';
 
class CalendarView extends Component {
  state = {
    date: new Date(),
  }
 
  onChange = date => this.setState({ date })
 
  render() {
    return (
      <div>
        <Calendar
          onChange={this.onChange}
          value={this.state.date}
        />
      </div>
    );
  }
}
export default CalendarView;
