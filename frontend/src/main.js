import { createApp } from 'vue';
import App from './App.vue';
import './index.css';
import router from './router';
import { createPinia } from 'pinia';
import apiClient from './plugins/apiClient';

const app = createApp(App);

const pinia = createPinia();

app.use(pinia);
app.use(router);
app.use(apiClient);

app.mount('#app');
