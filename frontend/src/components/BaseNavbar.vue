<template>
  <Disclosure as="nav" class="bg-indigo-600" v-slot="{ open }">
    <div class="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8">
      <div class="flex h-16 items-center justify-between">
        <div class="flex items-center">
          <div class="flex-shrink-0">
            <p class="text-white">Entertainment Center</p>
          </div>
          <div class="hidden md:block">
            <div class="ml-10 flex items-baseline space-x-4">
              <router-link
                  v-for="item in navigation"
                  :key="item.name"
                  :to="item.href"
                  class="rounded-md px-3 py-2 text-sm font-medium"
                  :class="{
                    'bg-indigo-700 text-white': isActiveRoute(item.href),
                    'text-white hover:bg-indigo-500 hover:bg-opacity-75': !isActiveRoute(item.href)
                  }"
              >{{ item.name }}</router-link>
            </div>
          </div>
        </div>
        <div class="hidden md:block">
          <div class="ml-4 flex items-center md:ml-6">
            <!-- Profile dropdown -->
            <Menu as="div" class="relative ml-3">
              <div>
                <MenuButton
                    class="relative flex max-w-xs items-center rounded-full bg-indigo-600 text-sm focus:outline-none focus:ring-2 focus:ring-white focus:ring-offset-2 focus:ring-offset-indigo-600"
                >
                  <span class="absolute -inset-1.5" />
                  <span class="sr-only">Open user menu</span>
                  <div class="text-white text-sm font-medium mr-2">{{ user.name }}</div>
                  <img class="h-8 w-8 rounded-full" :src="user.imageUrl" alt="" />
                </MenuButton>
              </div>
              <transition
                  enter-active-class="transition ease-out duration-100"
                  enter-from-class="transform opacity-0 scale-95"
                  enter-to-class="transform opacity-100 scale-100"
                  leave-active-class="transition ease-in duration-75"
                  leave-from-class="transform opacity-100 scale-100"
                  leave-to-class="transform opacity-0 scale-95"
              >
                <MenuItems
                    class="absolute right-0 z-10 mt-2 w-48 origin-top-right rounded-md bg-white py-1 shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none"
                >
                  <MenuItem v-for="item in filteredUserNavigation" :key="item.name" v-slot="{ active }">
                    <router-link
                        :to="item.href"
                        class="block px-4 py-2 text-sm text-gray-700"
                        :class="{ 'bg-gray-100': active }"
                    >{{ item.name }}</router-link>
                  </MenuItem>
                  <MenuItem v-slot="{ active }">
                    <button
                        @click="handleSignOut"
                        class="block w-full text-left px-4 py-2 text-sm text-gray-700"
                        :class="{ 'bg-gray-100': active }"
                    >Sign out</button>
                  </MenuItem>
                </MenuItems>
              </transition>
            </Menu>
          </div>
        </div>
        <div class="-mr-2 flex md:hidden">
          <!-- Mobile menu button -->
          <DisclosureButton
              class="relative inline-flex items-center justify-center rounded-md bg-indigo-600 p-2 text-indigo-200 hover:bg-indigo-500 hover:bg-opacity-75 hover:text-white focus:outline-none focus:ring-2 focus:ring-white focus:ring-offset-2 focus:ring-offset-indigo-600"
          >
            <span class="absolute -inset-0.5" />
            <span class="sr-only">Open main menu</span>
            <Bars3Icon v-if="!open" class="block h-6 w-6" aria-hidden="true" />
            <XMarkIcon v-else class="block h-6 w-6" aria-hidden="true" />
          </DisclosureButton>
        </div>
      </div>
    </div>

    <DisclosurePanel class="md:hidden">
      <div class="space-y-1 px-2 pb-3 pt-2 sm:px-3">
        <DisclosureButton
            v-for="item in navigation"
            :key="item.name"
            as="router-link"
            :to="item.href"
            class="block rounded-md px-3 py-2 text-base font-medium"
            :class="{
              'bg-indigo-700 text-white': isActiveRoute(item.href),
              'text-white hover:bg-indigo-500 hover:bg-opacity-75': !isActiveRoute(item.href)
            }"
            :aria-current="item.current ? 'page' : undefined"
        >{{ item.name }}</DisclosureButton>
      </div>
      <div class="border-t border-indigo-700 pb-3 pt-4">
        <div class="flex items-center px-5">
          <div class="flex-shrink-0">
            <img class="h-10 w-10 rounded-full" :src="user.imageUrl" alt="" />
          </div>
          <div class="ml-3">
            <div class="text-base font-medium text-white">{{ user.name }}</div>
            <div class="text-sm font-medium text-indigo-300">{{ user.email }}</div>
          </div>
          <button
              type="button"
              class="relative ml-auto flex-shrink-0 rounded-full bg-indigo-600 p-1 text-indigo-200 hover:text-white focus:outline-none focus:ring-2 focus:ring-white focus:ring-offset-2 focus:ring-offset-indigo-600"
          >
            <span class="absolute -inset-1.5" />
            <span class="sr-only">View notifications</span>
            <BellIcon class="h-6 w-6" aria-hidden="true" />
          </button>
        </div>
        <div class="mt-3 space-y-1 px-2">
          <DisclosureButton
              v-for="item in filteredUserNavigation"
              :key="item.name"
              as="router-link"
              :to="item.href"
              class="block rounded-md px-3 py-2 text-base font-medium text-white hover:bg-indigo-500 hover:bg-opacity-75"
          >{{ item.name }}</DisclosureButton>
          <DisclosureButton
              @click="handleSignOut"
              class="block rounded-md px-3 py-2 text-base font-medium text-white hover:bg-indigo-500 hover:bg-opacity-75"
          >Sign out</DisclosureButton>
        </div>
      </div>
    </DisclosurePanel>
  </Disclosure>
</template>

<script setup>
import { computed } from 'vue';
import { Disclosure, DisclosureButton, DisclosurePanel, Menu, MenuButton, MenuItem, MenuItems } from '@headlessui/vue';
import { Bars3Icon, BellIcon, XMarkIcon } from '@heroicons/vue/24/outline';
import { useRoute } from 'vue-router';
import { useAuthStore } from '../store/auth';

const route = useRoute();
const authStore = useAuthStore();

const user = {
  name: 'Tom Cook',
  email: 'tom@example.com',
  imageUrl: 'https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80',
};

const navigation = [
  {name: 'Home', href: '/', current: false},
  {name: 'Reserve area', href: '/reserve-area', current: false},
  {name: 'Events', href: '/events', current: false},
  {name: 'Career', href: '/career', current: false},
  {name: 'Contact', href: '/contact', current: false},
];

const userNavigation = [
  {name: 'Your Profile', href: '/profile'},
  {name: 'Settings', href: '/settings'},
  {name: 'Sign out', href: '/sign-out'},
];

const filteredUserNavigation = computed(() => {
  return userNavigation.filter(item => item.name !== 'Sign out');
});

const isActiveRoute = (href) => {
  return route.path === href;
};

const handleSignOut = () => {
  authStore.logout();
};
</script>
