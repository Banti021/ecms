<template>
  <div class="max-w-md mx-auto mt-10">
    <h2 class="text-2xl font-semibold mb-4">Login</h2>
    <form @submit.prevent="loginUser">
      <div class="mb-4">
        <label for="username" class="block text-sm font-medium text-gray-700">Username</label>
        <input type="text" v-model="username" id="username" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="password" class="block text-sm font-medium text-gray-700">Password</label>
        <input type="password" v-model="password" id="password" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div v-if="error" class="mb-4 text-red-500">
        {{ error }}
      </div>
      <div class="flex items-center justify-between">
        <button type="submit" class="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500">
          Login
        </button>
      </div>
    </form>
    <p class="mt-4">Don't have an account? <router-link to="/register" class="text-indigo-600">Register</router-link></p>
  </div>
</template>

<script setup>
import { ref } from 'vue';
import { useAuth } from '../composables/useAuth';

const username = ref('');
const password = ref('');
const { login, error } = useAuth();

const loginUser = async () => {
  await login({ username: username.value, password: password.value });
};
</script>
