import { createApp } from 'vue';
import App from './App.vue';
import './index.css';
import router from './router';
import axiosPlugin from './plugins/axios';

const app = createApp(App);

app.use(router);
app.use(axiosPlugin);

app.mount('#app');
