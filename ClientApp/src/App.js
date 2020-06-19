import React from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import IndexView from './views/IndexView';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import AboutView from './views/AboutView';
import TarotView from './views/TarotVIew';
import CalendarView from './views/CalendarView';
import FAQView from './views/FAQView';
import ShopView from './views/ShopView';
import AdminView from './views/AdminView';

const App = () => {
  return (

    <Layout>
      <Route exact path='/' component={IndexView} />
      <Route path='/counter' component={Counter} />
      <Route path='/fetch-data' component={FetchData} />
      <Route path='/about' component={AboutView} />
      <Route path='/tarot' component={TarotView} />
      <Route path='/schedule' component={CalendarView} />
      <Route path='/FAQs' component={FAQView} />
      <Route path='/shop' component={ShopView} />
      <Route path='/administratorlogin' component={AdminView} />
    </Layout>
  );
}
export default App;